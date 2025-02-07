﻿// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

using Xeptions;

namespace Standard.AI.OpenAI.Models.Services.Foundations.AIModels.Exceptions
{
    internal class AIModelDependencyValidationException : Xeption
    {
        public AIModelDependencyValidationException(Xeption innerException)
            : base(message: "AI Model dependency validation error occurred, fix errors and try again.",
                innerException)
        { }

        public AIModelDependencyValidationException(string message, Xeption innerException)
            : base(message: message, innerException)
        { }
    }
}
