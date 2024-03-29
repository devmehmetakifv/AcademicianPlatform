﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AcademicianPlatform.Areas.Admin
{
    public static class ManageNavPages
    {
        public static string Index => "Index";
        public static string EditUser => "EditUser";
        public static string Support => "Support";
        public static string EditMarqueeText => "EditMarqueeText";
        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);
        public static string EditUserNavClass(ViewContext viewContext) => PageNavClass(viewContext, EditUser);
        public static string SupportNavClass(ViewContext viewContext) => PageNavClass(viewContext, Support);
        public static string EditMarqueeTextNavClass(ViewContext viewContext) => PageNavClass(viewContext, EditMarqueeText);
        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}
