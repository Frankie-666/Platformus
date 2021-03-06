﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Platformus.Barebone.Backend.ViewModels
{
  public abstract class ViewModelBuilderBase : Platformus.Barebone.ViewModels.ViewModelBuilderBase
  {
    public ViewModelBuilderBase(IHandler handler)
      : base(handler)
    {
      this.handler = handler;
    }
  }
}