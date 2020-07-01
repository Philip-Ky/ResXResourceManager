﻿namespace ResXManager.VSIX.Visuals
{
    using System;
    using System.Composition;

    using JetBrains.Annotations;

    using ResXManager.Infrastructure;

    using TomsToolbox.Composition;
    using TomsToolbox.Wpf.Composition;
    using TomsToolbox.Wpf.Composition.AttributedModel;

    /// <summary>
    /// Interaction logic for CodeGeneratorView.xaml
    /// </summary>
    [VisualCompositionExport(RegionId.ProjectListItemDecorator)]
    [Shared]
    public partial class CodeGeneratorView
    {
        [ImportingConstructor]
        public CodeGeneratorView([NotNull] IExportProvider exportProvider)
        {
            try
            {
                this.SetExportProvider(exportProvider);

                InitializeComponent();
            }
            catch (Exception ex)
            {
                exportProvider.TraceXamlLoaderError(ex);
            }
        }
    }
}