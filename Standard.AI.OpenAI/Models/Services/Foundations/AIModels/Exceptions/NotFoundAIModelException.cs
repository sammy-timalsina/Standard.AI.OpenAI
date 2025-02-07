﻿// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

using System;
using Xeptions;

namespace Standard.AI.OpenAI.Models.Services.Foundations.AIModels.Exceptions
{
    public class NotFoundAIModelException : Xeption
    {
        public NotFoundAIModelException(Exception innerException)
            : base(message: "AI Model not found.",
                  innerException)
        { }

        public NotFoundAIModelException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
