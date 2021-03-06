﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Protocols.ReportingTool {
    using System;
    
    
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Protocols.ReportingTool.Resource", typeof(Resource).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table cellpadding=&quot;2&quot; cellspacing=&quot;2&quot;&gt;
        ///    &lt;caption&gt;&lt;h3&gt;Requirements Excluded From Failed Cases&lt;/h3&gt;&lt;/caption&gt;
        ///    &lt;col /&gt;
        ///    &lt;thead&gt;
        ///      &lt;tr&gt;
        ///          &lt;td style=&quot;width: 12%;&quot; class=&quot;TableCellHighlighted&quot;&gt;
        ///              Req ID
        ///          &lt;/td&gt;
        ///          &lt;td class=&quot;TableCellHighlighted&quot;&gt;
        ///              Description
        ///          &lt;/td&gt;
        ///          &lt;td style=&quot;width: 10%;&quot; class=&quot;TableCellHighlighted&quot;&gt;
        ///              TestCase
        ///          &lt;/td&gt;
        ///          &lt;td style=&quot;width: 10%;&quot; class=&quot;TableCellHighlighted [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExcludReqTable {
            get {
                return ResourceManager.GetString("ExcludReqTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table cellpadding=&quot;2&quot; cellspacing=&quot;2&quot;&gt;
        ///    &lt;caption&gt;&lt;h3&gt;$GLOBALTABLETITLE$&lt;br/&gt;
        ///                  &lt;font color=&quot;#FF0000&quot;&gt;$ErrorMessage$&lt;/font&gt;&lt;/h3&gt;
        ///                  &lt;h4&gt;$GLOBALTABLEDISCRIPTION$&lt;/h4&gt;&lt;/caption&gt;
        ///    &lt;col /&gt;
        ///    &lt;thead&gt;&lt;tr&gt;&lt;th colspan=&quot;2&quot;&gt;Requirement Type&lt;/th&gt;&lt;th colspan=&quot;5&quot;&gt;Count/Percent&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;
        ///    &lt;col /&gt;
        ///    &lt;tbody&gt;
        ///    &lt;tr&gt;
        ///        &lt;td colspan=&quot;7&quot;&gt;
        ///        &lt;h3&gt;
        ///            Checked Requirements:  %totalChecked%
        ///        &lt;/h3&gt;
        ///        &lt;/td&gt;
        ///    &lt;/tr&gt;
        ///    &lt;tr&gt;
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GlobalTable {
            get {
                return ResourceManager.GetString("GlobalTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} -
        ///    A utility which generates reports from PTF test logs and requirement table files.
        ///
        ///{0} /log:&lt;xml log&gt; /table:&lt;requirements table&gt;[/out:report.html] [/replace] [/inscope:values] [/outofscope:values] [/prefix:MS-XXXX] [/verbose]
        ///{0} /log:&lt;xml log&gt;[&lt;xml log&gt;....] /table:&lt;requirements table&gt;[&lt;requirements table&gt;...] [/out:report.html] [/replace] [/inscope:values] [/outofscope:values] [/prefix:MS-XXXX] [/verbose]
        ///
        ///    - OPTIONS -
        ///
        ////help
        ///    Prints this help message. Short form is &apos;/?&apos;.
        ///
        ////out [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HelpText {
            get {
                return ResourceManager.GetString("HelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to $GLOBALSTAT$
        ///    &lt;br/&gt;
        ///    $GLOBALRSINCONSISTENCY$
        ///    &lt;br/&gt;
        ///    $GLOBALINCONSISTENCY$
        ///    &lt;br/&gt;
        ///    $EXCLUDEDREQUIREMENTS$
        ///      &lt;/body&gt;
        ///  &lt;/html&gt;.
        /// </summary>
        internal static string HtmlTemplateFooter {
            get {
                return ResourceManager.GetString("HtmlTemplateFooter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html PUBLIC &quot;-//W3C//DTD XHTML 1.0 Transitional//EN&quot; &quot;http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd&quot;&gt;
        ///&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot; &gt;
        ///&lt;head&gt;
        ///    &lt;meta http-equiv=&quot;content-type&quot; content=&quot;text/html; charset=UTF-8&quot; /&gt;
        ///    &lt;title&gt;Reporting&lt;/title&gt;
        ///    &lt;style type=&quot;text/css&quot;&gt;
        ///    table
        ///    {
        ///        width: 100%;
        ///        background-color: #f8f8f8;
        ///        border: 1px solid #505050;
        ///        border-collapse: collapse;
        ///    }
        ///    tbody tr td
        ///    {
        ///        border: 1px so [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HtmlTemplateHeader {
            get {
                return ResourceManager.GetString("HtmlTemplateHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;br /&gt;The following data might not be accurate due to inconsistencies found in the requirements, please see &lt;a href=&apos;#jump-rsinconsistencyerrors&apos;&gt;Requirement Inconsistencies&lt;/a&gt; for details..
        /// </summary>
        internal static string InconsistencyErrorMessage {
            get {
                return ResourceManager.GetString("InconsistencyErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table cellpadding=&quot;2&quot; cellspacing=&quot;2&quot;&gt;
        ///    &lt;col/&gt;
        ///    &lt;thead&gt;
        ///        &lt;tr&gt;
        ///              &lt;td align=&quot;center&quot; class=&quot;TableCellHighlighted&quot; colspan=&quot;5&quot;&gt;
        ///                  &lt;h4&gt;Requirement Verification Inconsistencies&lt;/h4&gt;
        ///              &lt;/td&gt;
        ///        &lt;/tr&gt;
        ///        &lt;tr&gt;
        ///            &lt;th colspan=&quot;3&quot;&gt;Inconsistency type&lt;/th&gt;
        ///            &lt;th colspan=&quot;2&quot;&gt;Count&lt;/th&gt;
        ///        &lt;/tr&gt;
        ///     &lt;/thead&gt;
        ///    &lt;col/&gt;
        ///    &lt;tbody&gt;
        ///    &lt;tr&gt;
        ///        &lt;td colspan=&quot;3&quot;&gt;
        ///            $InconsistentErrors$
        ///        &lt;/td&gt;
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InconsistencyTable {
            get {
                return ResourceManager.GetString("InconsistencyTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     &lt;table&gt;
        ///        &lt;caption&gt;&lt;h3&gt;Report For Log $FILENAME$&lt;/h3&gt;&lt;/caption&gt;
        ///        &lt;tr&gt;
        ///            &lt;td&gt;
        ///                Target Protocol: $PROTOCOL$&lt;/td&gt;
        ///            &lt;td&gt;
        ///                Log File: $FILENAME$
        ///            &lt;/td&gt;
        ///        &lt;/tr&gt;
        ///        &lt;tr&gt;
        ///            &lt;td align=&quot;center&quot; class=&quot;TableCellHighlighted&quot; colspan=&quot;2&quot;&gt;
        ///                PTFConfigProperties
        ///            &lt;/td&gt;
        ///        &lt;/tr&gt;
        ///        $CONFIG$
        ///        &lt;tr&gt;
        ///            &lt;td align=&quot;center&quot; class=&quot;TableCellHighlighted&quot; colspan=&quot;2&quot;&gt;        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LogTable {
            get {
                return ResourceManager.GetString("LogTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     &lt;table&gt;
        ///        &lt;tr&gt;
        ///            &lt;td align=&quot;center&quot; class=&quot;TableCellHighlighted&quot; colspan=&quot;2&quot;&gt;
        ///                Requirement Coverage
        ///            &lt;/td&gt;
        ///        &lt;/tr&gt;
        ///        &lt;tr&gt;
        ///        &lt;td&gt;Total requirements&lt;/td&gt;
        ///        &lt;td&gt;$Total$&lt;/td&gt;
        ///        &lt;/tr&gt;
        ///        &lt;tr&gt;
        ///        &lt;td&gt;Normative, in-scope and testable requirements&lt;/td&gt;
        ///        &lt;td&gt;$Verifiable$&lt;/td&gt;
        ///        &lt;/tr&gt;
        ///        &lt;tr&gt;
        ///        &lt;td&gt;Verified requirements&lt;/td&gt;
        ///        &lt;td&gt;$Verified$
        ///                &lt;/td&gt;
        ///        &lt;/tr&gt;
        ///        [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ReqTable {
            get {
                return ResourceManager.GetString("ReqTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema targetNamespace=&quot;http://schemas.microsoft.com/windows/ProtocolsTest/2007/07/RequirementTable&quot;
        ///           xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;
        ///           xmlns:rt=&quot;http://schemas.microsoft.com/windows/ProtocolsTest/2007/07/RequirementTable&quot;
        ///           elementFormDefault=&quot;qualified&quot; attributeFormDefault=&quot;unqualified&quot;&gt;
        ///
        ///  &lt;xs:simpleType name=&quot;isExtension_type&quot;&gt;
        ///    &lt;xs:restriction base=&quot;xs:string&quot;&gt;
        ///      &lt;!-- Non-extension or Extension --&gt;
        ///      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string requirementTable {
            get {
                return ResourceManager.GetString("requirementTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to       
        ///      &lt;table cellpadding=&quot;2&quot; cellspacing=&quot;2&quot;&gt;
        ///      &lt;col /&gt;
        ///      &lt;thead&gt;
        ///          &lt;tr&gt;
        ///              &lt;td align=&quot;center&quot; class=&quot;TableCellHighlighted&quot; colspan=&quot;3&quot;&gt;
        ///                  &lt;h4&gt;Requirement Inconsistencies&lt;/h4&gt;
        ///              &lt;/td&gt;
        ///          &lt;/tr&gt;
        ///      &lt;/thead&gt;
        ///      &lt;col /&gt;
        ///      &lt;tbody&gt;
        ///          &lt;tr&gt;
        ///              &lt;td colspan=&quot;2&quot; style=&quot;width: 87%;&quot;&gt;
        ///                  $RSERRORS$
        ///              &lt;/td&gt;
        ///              &lt;td colspan=&quot;1&quot; style=&quot;width: 13%;&quot; title=&quot;click to see detail [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RSInconsistencyTable {
            get {
                return ResourceManager.GetString("RSInconsistencyTable", resourceCulture);
            }
        }
    }
}
