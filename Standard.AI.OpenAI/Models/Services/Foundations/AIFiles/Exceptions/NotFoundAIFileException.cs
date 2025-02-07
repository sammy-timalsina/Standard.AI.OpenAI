﻿// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

using System;
using Xeptions;

namespace Standard.AI.OpenAI.Models.Services.Foundations.AIFiles.Exceptions
{
    public class NotFoundAIFileException : Xeption
    {
        public NotFoundAIFileException(Exception innerException)
            : base(message: "Not found AI file error occurred, fix errors and try again.",
                  innerException)
        { }

        public NotFoundAIFileException(string message, Exception innerException)
            : base(message: message, innerException)
        { }
    }
}