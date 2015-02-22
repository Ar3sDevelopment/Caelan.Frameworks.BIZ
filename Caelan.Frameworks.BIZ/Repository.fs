﻿namespace Caelan.Frameworks.BIZ.Classes

open System
open System.Collections.Generic
open System.Linq
open System.Linq.Expressions
open System.Reflection
open Caelan.DynamicLinq.Classes
open Caelan.DynamicLinq.Extensions
open Caelan.Frameworks.Common.Classes
open Caelan.Frameworks.Common.Interfaces
open Caelan.Frameworks.BIZ.Interfaces

[<AbstractClass>]
type Repository(manager) = 
    interface IRepository with
        member this.UnitOfWork = this.UnitOfWork
    
    member val UnitOfWork = manager