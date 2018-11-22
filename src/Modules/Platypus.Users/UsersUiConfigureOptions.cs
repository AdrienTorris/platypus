namespace Platypus.Users
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.StaticFiles;
    using Microsoft.Extensions.FileProviders;
    using Microsoft.Extensions.Options;
    using Platypus.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class UsersUiConfigureOptions : BaseModuleUiConfigureOptions
    {
        public UsersUiConfigureOptions(IHostingEnvironment environment)
            : base(environment)
        {
        }
    }
}