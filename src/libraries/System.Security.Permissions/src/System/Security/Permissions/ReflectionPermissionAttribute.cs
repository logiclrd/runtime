// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Security.Permissions
{
#if NET
    [Obsolete(Obsoletions.CodeAccessSecurityMessage, DiagnosticId = Obsoletions.CodeAccessSecurityDiagId, UrlFormat = Obsoletions.SharedUrlFormat)]
#endif
    [AttributeUsage((AttributeTargets)(109), AllowMultiple = true, Inherited = false)]
    public sealed partial class ReflectionPermissionAttribute : CodeAccessSecurityAttribute
    {
        public ReflectionPermissionAttribute(SecurityAction action) : base(default(SecurityAction)) { }
        public ReflectionPermissionFlag Flags { get; set; }
        public bool MemberAccess { get; set; }
        [Obsolete("ReflectionPermissionAttribute.ReflectionEmit has been deprecated and is not supported.")]
        public bool ReflectionEmit { get; set; }
        public bool RestrictedMemberAccess { get; set; }
        [Obsolete("ReflectionPermissionAttribute.TypeInformation has been deprecated and is not supported.")]
        public bool TypeInformation { get; set; }
        public override IPermission CreatePermission() { return default(IPermission); }
    }
}
