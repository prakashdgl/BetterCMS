﻿using BetterCms.Core.Modules;
using BetterCms.Core.Modules.JsModule;
using BetterCms.Core.Modules.Projections;
using BetterCms.Module.MediaManager.Controllers;
using BetterCms.Module.MediaManager.Content.Resources;

namespace BetterCms.Module.MediaManager.Registration
{
    /// <summary>
    /// bcms.pages.js module descriptor.
    /// </summary>
    public class ImageEditorJavaScriptModuleDescriptor : JavaScriptModuleDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEditorJavaScriptModuleDescriptor" /> class.
        /// </summary>
        /// <param name="containerModule">The container module.</param>
        public ImageEditorJavaScriptModuleDescriptor(ModuleDescriptor containerModule)
            : base(containerModule, "bcms.media.imageeditor", "/file/bcms-media/scripts/bcms.media.imageeditor")
        {
            Links = new IActionProjection[]
                {
                    new JavaScriptModuleLinkTo<ImagesController>(this, "imageEditorDialogUrl", c => c.ImageEditor("{0}")),
                    new JavaScriptModuleLinkTo<ImagesController>(this, "imageEditorInsertDialogUrl", c => c.ImageEditorInsert("{0}"))
                };

            Globalization = new IActionProjection[]
                {
                    new JavaScriptModuleGlobalization(this, "imageEditorDialogTitle", () => MediaGlobalization.ImageEditor_Dialog_Title),
                    new JavaScriptModuleGlobalization(this, "imageEditorInsertDialogTitle", () => MediaGlobalization.ImageEditor_InsertDialog_Title),
                    new JavaScriptModuleGlobalization(this, "imageEditorInsertDialogAcceptButton", () => MediaGlobalization.ImageEditor_InsertDialog_AcceptButton),
                    new JavaScriptModuleGlobalization(this, "imageEditorUpdateFailureMessageTitle", () => MediaGlobalization.ImageEditor_UpdateFailureMessage_Title),
                    new JavaScriptModuleGlobalization(this, "imageEditorUpdateFailureMessageMessage", () => MediaGlobalization.ImageEditor_UpdateFailureMessage_Message)
                };
        }
    }
}