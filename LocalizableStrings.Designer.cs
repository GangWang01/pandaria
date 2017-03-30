﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.TemplateEngine.Cli {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class LocalizableStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizableStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.TemplateEngine.Cli.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Alias.
        /// </summary>
        public static string Alias {
            get {
                return ResourceManager.GetString("Alias", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified alias &quot;{0}&quot; already exists. Please specify a different alias..
        /// </summary>
        public static string AliasAlreadyExists {
            get {
                return ResourceManager.GetString("AliasAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Alias creation successful..
        /// </summary>
        public static string AliasCreated {
            get {
                return ResourceManager.GetString("AliasCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not allow scripts to run.
        /// </summary>
        public static string AllowScriptsNoChoice {
            get {
                return ResourceManager.GetString("AllowScriptsNoChoice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ask before running each script.
        /// </summary>
        public static string AllowScriptsPromptChoice {
            get {
                return ResourceManager.GetString("AllowScriptsPromptChoice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allow scripts to run.
        /// </summary>
        public static string AllowScriptsYesChoice {
            get {
                return ResourceManager.GetString("AllowScriptsYesChoice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine the desired template from the input template name: {0}..
        /// </summary>
        public static string AmbiguousInputTemplateName {
            get {
                return ResourceManager.GetString("AmbiguousInputTemplateName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified extra args file does not exist: {0}..
        /// </summary>
        public static string ArgsFileNotFound {
            get {
                return ResourceManager.GetString("ArgsFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extra args file {0} is not formatted properly..
        /// </summary>
        public static string ArgsFileWrongFormat {
            get {
                return ResourceManager.GetString("ArgsFileWrongFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly.
        /// </summary>
        public static string Assembly {
            get {
                return ResourceManager.GetString("Assembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Author: {0}.
        /// </summary>
        public static string Author {
            get {
                return ResourceManager.GetString("Author", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid format for input locale: &quot;{0}&quot;. Example valid formats: [en] [en-US]..
        /// </summary>
        public static string BadLocaleError {
            get {
                return ResourceManager.GetString("BadLocaleError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not install &quot;{0}&quot;..
        /// </summary>
        public static string BadPackageSpec {
            get {
                return ResourceManager.GetString("BadPackageSpec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change.
        /// </summary>
        public static string Change {
            get {
                return ResourceManager.GetString("Change", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking for updates for {0}....
        /// </summary>
        public static string CheckingForUpdates {
            get {
                return ResourceManager.GetString("CheckingForUpdates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template Instantiation Commands for .NET Core CLI.
        /// </summary>
        public static string CommandDescription {
            get {
                return ResourceManager.GetString("CommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command failed..
        /// </summary>
        public static string CommandFailed {
            get {
                return ResourceManager.GetString("CommandFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output from command:
        ///{0}.
        /// </summary>
        public static string CommandOutput {
            get {
                return ResourceManager.GetString("CommandOutput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command succeeded..
        /// </summary>
        public static string CommandSucceeded {
            get {
                return ResourceManager.GetString("CommandSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configured Value: {0}.
        /// </summary>
        public static string ConfiguredValue {
            get {
                return ResourceManager.GetString("ConfiguredValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Continue?.
        /// </summary>
        public static string ContinueQuestion {
            get {
                return ResourceManager.GetString("ContinueQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creates an alias for the specified template..
        /// </summary>
        public static string CreateAliasHelp {
            get {
                return ResourceManager.GetString("CreateAliasHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indicates whether to create a directory for the generated content..
        /// </summary>
        public static string CreateDirectoryHelp {
            get {
                return ResourceManager.GetString("CreateDirectoryHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template &quot;{0}&quot; could not be created.
        ///{1}.
        /// </summary>
        public static string CreateFailed {
            get {
                return ResourceManager.GetString("CreateFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The template &quot;{0}&quot; was created successfully..
        /// </summary>
        public static string CreateSuccessful {
            get {
                return ResourceManager.GetString("CreateSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current configuration:.
        /// </summary>
        public static string CurrentConfiguration {
            get {
                return ResourceManager.GetString("CurrentConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default: {0}.
        /// </summary>
        public static string DefaultValue {
            get {
                return ResourceManager.GetString("DefaultValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete.
        /// </summary>
        public static string Delete {
            get {
                return ResourceManager.GetString("Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Description: {0}.
        /// </summary>
        public static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating this template will make changes to existing files:.
        /// </summary>
        public static string DestructiveChangesNotification {
            get {
                return ResourceManager.GetString("DestructiveChangesNotification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays help for this command..
        /// </summary>
        public static string DisplaysHelp {
            get {
                return ResourceManager.GetString("DisplaysHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies a file containing additional parameters..
        /// </summary>
        public static string ExtraArgsFileHelp {
            get {
                return ResourceManager.GetString("ExtraArgsFileHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Factory.
        /// </summary>
        public static string Factory {
            get {
                return ResourceManager.GetString("Factory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forces content to be generated even if it would change existing files..
        /// </summary>
        public static string ForcesTemplateCreation {
            get {
                return ResourceManager.GetString("ForcesTemplateCreation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generators.
        /// </summary>
        public static string Generators {
            get {
                return ResourceManager.GetString("Generators", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be created in the target location..
        /// </summary>
        public static string GenericPlaceholderTemplateContextError {
            get {
                return ResourceManager.GetString("GenericPlaceholderTemplateContextError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Getting ready....
        /// </summary>
        public static string GettingReady {
            get {
                return ResourceManager.GetString("GettingReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Id.
        /// </summary>
        public static string Id {
            get {
                return ResourceManager.GetString("Id", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; could not be installed.
        ///{1}..
        /// </summary>
        public static string InstallFailed {
            get {
                return ResourceManager.GetString("InstallFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installs a source or a template pack..
        /// </summary>
        public static string InstallHelp {
            get {
                return ResourceManager.GetString("InstallHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installing updates....
        /// </summary>
        public static string InstallingUpdates {
            get {
                return ResourceManager.GetString("InstallingUpdates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; was installed successfully..
        /// </summary>
        public static string InstallSuccessful {
            get {
                return ResourceManager.GetString("InstallSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid input switch:.
        /// </summary>
        public static string InvalidInputSwitch {
            get {
                return ResourceManager.GetString("InvalidInputSwitch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} {1}
        ///    &apos;{1}&apos; is not a valid value for {0} ({2})..
        /// </summary>
        public static string InvalidParameterDetail {
            get {
                return ResourceManager.GetString("InvalidParameterDetail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Invalid values for parameter(s) {0} for template {1}..
        /// </summary>
        public static string InvalidParameterValues {
            get {
                return ResourceManager.GetString("InvalidParameterValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Invalid parameter(s):.
        /// </summary>
        public static string InvalidTemplateParameterValues {
            get {
                return ResourceManager.GetString("InvalidTemplateParameterValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Language.
        /// </summary>
        public static string Language {
            get {
                return ResourceManager.GetString("Language", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the language of the template to create..
        /// </summary>
        public static string LanguageParameter {
            get {
                return ResourceManager.GetString("LanguageParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lists templates containing the specified name. If no name is specified, lists all templates..
        /// </summary>
        public static string ListsTemplates {
            get {
                return ResourceManager.GetString("ListsTemplates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The locale to use..
        /// </summary>
        public static string LocaleHelp {
            get {
                return ResourceManager.GetString("LocaleHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mandatory parameter {0} missing for template {1}..
        /// </summary>
        public static string MissingRequiredParameter {
            get {
                return ResourceManager.GetString("MissingRequiredParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mount Point Factories.
        /// </summary>
        public static string MountPointFactories {
            get {
                return ResourceManager.GetString("MountPointFactories", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mount Points.
        /// </summary>
        public static string MountPoints {
            get {
                return ResourceManager.GetString("MountPoints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template name is the only allowed argument. Invalid argument: {0}..
        /// </summary>
        public static string MultipleArgsSpecifiedError {
            get {
                return ResourceManager.GetString("MultipleArgsSpecifiedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple values specified for single value parameter: {0}..
        /// </summary>
        public static string MultipleValuesSpecifiedForSingleValuedParameter {
            get {
                return ResourceManager.GetString("MultipleValuesSpecifiedForSingleValuedParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name for the output being created. If no name is specified, the name of the current directory is used..
        /// </summary>
        public static string NameOfOutput {
            get {
                return ResourceManager.GetString("NameOfOutput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (No Items).
        /// </summary>
        public static string NoItems {
            get {
                return ResourceManager.GetString("NoItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     (No Parameters).
        /// </summary>
        public static string NoParameters {
            get {
                return ResourceManager.GetString("NoParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Primary Outputs to restore..
        /// </summary>
        public static string NoPrimaryOutputsToRestore {
            get {
                return ResourceManager.GetString("NoPrimaryOutputsToRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No templates matched the input template name: {0}..
        /// </summary>
        public static string NoTemplatesMatchName {
            get {
                return ResourceManager.GetString("NoTemplatesMatchName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No updates were found..
        /// </summary>
        public static string NoUpdates {
            get {
                return ResourceManager.GetString("NoUpdates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options:.
        /// </summary>
        public static string Options {
            get {
                return ResourceManager.GetString("Options", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Option variant {0} for canonical {1} was already defined for canonical {2}..
        /// </summary>
        public static string OptionVariantAlreadyDefined {
            get {
                return ResourceManager.GetString("OptionVariantAlreadyDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location to place the generated output..
        /// </summary>
        public static string OutputPath {
            get {
                return ResourceManager.GetString("OutputPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwrite.
        /// </summary>
        public static string Overwrite {
            get {
                return ResourceManager.GetString("Overwrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter {0} ({1}) must be given a value..
        /// </summary>
        public static string ParameterMissingValue {
            get {
                return ResourceManager.GetString("ParameterMissingValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter names must start with -- or -..
        /// </summary>
        public static string ParameterNamePrefixError {
            get {
                return ResourceManager.GetString("ParameterNamePrefixError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter name {0} cannot be used for multiple purposes..
        /// </summary>
        public static string ParameterReuseError {
            get {
                return ResourceManager.GetString("ParameterReuseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter {0} was specified multiple times, including with the flag {1}..
        /// </summary>
        public static string ParameterSpecifiedMultipleTimes {
            get {
                return ResourceManager.GetString("ParameterSpecifiedMultipleTimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parent.
        /// </summary>
        public static string Parent {
            get {
                return ResourceManager.GetString("Parent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actual command: {0}.
        /// </summary>
        public static string PostActionCommand {
            get {
                return ResourceManager.GetString("PostActionCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Description: {0}.
        /// </summary>
        public static string PostActionDescription {
            get {
                return ResourceManager.GetString("PostActionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manual instructions: {0}.
        /// </summary>
        public static string PostActionInstructions {
            get {
                return ResourceManager.GetString("PostActionInstructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid input &quot;{0}&quot;. Please enter one of (Y|N)..
        /// </summary>
        public static string PostActionInvalidInputRePrompt {
            get {
                return ResourceManager.GetString("PostActionInvalidInputRePrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template is configured to run the following action:.
        /// </summary>
        public static string PostActionPromptHeader {
            get {
                return ResourceManager.GetString("PostActionPromptHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to run this action (Y|N)?.
        /// </summary>
        public static string PostActionPromptRequest {
            get {
                return ResourceManager.GetString("PostActionPromptRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing Post Actions.
        /// </summary>
        public static string ProcessingPostActions {
            get {
                return ResourceManager.GetString("ProcessingPostActions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Doesn&apos;t output any status information..
        /// </summary>
        public static string QuietModeHelp {
            get {
                return ResourceManager.GetString("QuietModeHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rerun the command and pass --force to accept and create..
        /// </summary>
        public static string RerunCommandAndPassForceToCreateAnyway {
            get {
                return ResourceManager.GetString("RerunCommandAndPassForceToCreateAnyway", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restore failed..
        /// </summary>
        public static string RestoreFailed {
            get {
                return ResourceManager.GetString("RestoreFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restore succeeded..
        /// </summary>
        public static string RestoreSucceeded {
            get {
                return ResourceManager.GetString("RestoreSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Run dotnet {0} --help for usage information..
        /// </summary>
        public static string RunHelpForInformationAboutAcceptedParameters {
            get {
                return ResourceManager.GetString("RunHelpForInformationAboutAcceptedParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running command &apos;{0}&apos;....
        /// </summary>
        public static string RunningCommand {
            get {
                return ResourceManager.GetString("RunningCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running &apos;dotnet restore&apos; on {0}....
        /// </summary>
        public static string RunningDotnetRestoreOn {
            get {
                return ResourceManager.GetString("RunningDotnetRestoreOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Short Name.
        /// </summary>
        public static string ShortName {
            get {
                return ResourceManager.GetString("ShortName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shows all templates..
        /// </summary>
        public static string ShowsAllTemplates {
            get {
                return ResourceManager.GetString("ShowsAllTemplates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shows a subset of the available templates. Valid values are &quot;project&quot;, &quot;item&quot; or &quot;other&quot;..
        /// </summary>
        public static string ShowsFilteredTemplates {
            get {
                return ResourceManager.GetString("ShowsFilteredTemplates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tags.
        /// </summary>
        public static string Tags {
            get {
                return ResourceManager.GetString("Tags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The template to instantiate..
        /// </summary>
        public static string TemplateArgumentHelp {
            get {
                return ResourceManager.GetString("TemplateArgumentHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template is malformed. The following parameter names are invalid: {0}..
        /// </summary>
        public static string TemplateMalformedDueToBadParameters {
            get {
                return ResourceManager.GetString("TemplateMalformedDueToBadParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following templates partially match the input. Be more specific with the template name and/or language..
        /// </summary>
        public static string TemplateMultiplePartialNameMatches {
            get {
                return ResourceManager.GetString("TemplateMultiplePartialNameMatches", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} matches the specified name, but has been excluded by the --type parameter. Remove or change the --type parameter to use that template..
        /// </summary>
        public static string TemplateNotValidGivenTheSpecifiedFilter {
            get {
                return ResourceManager.GetString("TemplateNotValidGivenTheSpecifiedFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Templates.
        /// </summary>
        public static string Templates {
            get {
                return ResourceManager.GetString("Templates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This template contains technologies from parties other than Microsoft, see {0} for details..
        /// </summary>
        public static string ThirdPartyNotices {
            get {
                return ResourceManager.GetString("ThirdPartyNotices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type.
        /// </summary>
        public static string Type {
            get {
                return ResourceManager.GetString("Type", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Change.
        /// </summary>
        public static string UnknownChangeKind {
            get {
                return ResourceManager.GetString("UnknownChangeKind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An update for {0} is available....
        /// </summary>
        public static string UpdateAvailable {
            get {
                return ResourceManager.GetString("UpdateAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update matching templates..
        /// </summary>
        public static string UpdateHelp {
            get {
                return ResourceManager.GetString("UpdateHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value specified for valueless parameter: {0}..
        /// </summary>
        public static string ValueSpecifiedForValuelessParameter {
            get {
                return ResourceManager.GetString("ValueSpecifiedForValuelessParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify if post action scripts should run..
        /// </summary>
        public static string WhetherToAllowScriptsToRun {
            get {
                return ResourceManager.GetString("WhetherToAllowScriptsToRun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About to create: .
        /// </summary>
        public static string WillCreateTemplate {
            get {
                return ResourceManager.GetString("WillCreateTemplate", resourceCulture);
            }
        }
    }
}
