﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3607
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class OrmapAnnotateToolbarResource
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("OrmapTaxlotEditing.OrmapAnnotateToolbarResource", GetType(OrmapAnnotateToolbarResource).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Friend Shared ReadOnly Property CreateAnnotation() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CreateAnnotation", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend Shared ReadOnly Property InvertAnnotation() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("InvertAnnotation", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend Shared ReadOnly Property MoveDown() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("MoveDown", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend Shared ReadOnly Property MoveUp() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("MoveUp", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend Shared ReadOnly Property StandardBothSidesDown() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("StandardBothSidesDown", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend Shared ReadOnly Property StandardBothSidesUp() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("StandardBothSidesUp", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend Shared ReadOnly Property TransposeAnnotation() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TransposeAnnotation", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend Shared ReadOnly Property WideBothSidesDown() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("WideBothSidesDown", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend Shared ReadOnly Property WideBothSidesUp() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("WideBothSidesUp", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Class
End Namespace
