﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.269
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")>  _
Partial Friend NotInheritable Class passwords
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As passwords = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New passwords()),passwords)
    
    Public Shared ReadOnly Property [Default]() As passwords
        Get
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("$keletonK3y")>  _
    Public Property masterpass() As String
        Get
            Return CType(Me("masterpass"),String)
        End Get
        Set
            Me("masterpass") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property trys() As Integer
        Get
            Return CType(Me("trys"),Integer)
        End Get
        Set
            Me("trys") = value
        End Set
    End Property
End Class
