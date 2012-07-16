'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.239
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Desktop.AddIns
Imports ESRI.ArcGIS.Editor
Imports ESRI.ArcGIS.esriSystem
Imports ESRI.ArcGIS.Framework
Imports System
Imports System.Collections.Generic

Namespace My
    
    '''<summary>
    '''A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    '''</summary>
    Friend Module ThisAddIn
        
        Friend ReadOnly Property Name() As String
            Get
                Return "OrmapTaxlotEditingAddIn"
            End Get
        End Property
        
        Friend ReadOnly Property AddInID() As String
            Get
                Return "{dce1ac77-251b-4cd6-937c-1d68e84399e6}"
            End Get
        End Property
        
        Friend ReadOnly Property Company() As String
            Get
                Return "ORMAP"
            End Get
        End Property
        
        Friend ReadOnly Property Version() As String
            Get
                Return "3.0.0"
            End Get
        End Property
        
        Friend ReadOnly Property Description() As String
            Get
                Return "The ORMAP Parcel Editing Toolbar is a set of tools for editing parcel data via ES"& _ 
                    "RI's ArcGIS. The tools consist of an ArcMap toolbar for use in ArcMap version 10"& _ 
                    "."
            End Get
        End Property
        
        Friend ReadOnly Property Author() As String
            Get
                Return "ORMAP Tools Group"
            End Get
        End Property
        
        Friend ReadOnly Property [Date]() As String
            Get
                Return "9/1/2011"
            End Get
        End Property
        
        '''<summary>
        '''A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        '''</summary>
        Friend Class IDs
            
            '''<summary>
            '''Returns 'ORMAP_OrmapTaxlotEditing_AutoUpdateAllToggle', the id declared for Add-in Button class 'AutoUpdateAllToggle'
            '''</summary>
            Friend Shared ReadOnly Property AutoUpdateAllToggle() As String
                Get
                    Return "ORMAP_OrmapTaxlotEditing_AutoUpdateAllToggle"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_OrmapTaxlotEditing_CombineTaxlots', the id declared for Add-in Button class 'CombineTaxlots'
            '''</summary>
            Friend Shared ReadOnly Property CombineTaxlots() As String
                Get
                    Return "ORMAP_OrmapTaxlotEditing_CombineTaxlots"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_OrmapTaxlotEditing_LocateFeature', the id declared for Add-in Button class 'LocateFeature'
            '''</summary>
            Friend Shared ReadOnly Property LocateFeature() As String
                Get
                    Return "ORMAP_OrmapTaxlotEditing_LocateFeature"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_OrmapTaxlotEditing_OrmapSettings', the id declared for Add-in Button class 'OrmapSettings'
            '''</summary>
            Friend Shared ReadOnly Property OrmapSettings() As String
                Get
                    Return "ORMAP_OrmapTaxlotEditing_OrmapSettings"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_OrmapTaxlotEditing_EditMapIndex', the id declared for Add-in Button class 'EditMapIndex'
            '''</summary>
            Friend Shared ReadOnly Property EditMapIndex() As String
                Get
                    Return "ORMAP_OrmapTaxlotEditing_EditMapIndex"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_OrmapTaxlotEditing_SortCancelledNumbers', the id declared for Add-in Button class 'SortCancelledNumbers'
            '''</summary>
            Friend Shared ReadOnly Property SortCancelledNumbers() As String
                Get
                    Return "ORMAP_OrmapTaxlotEditing_SortCancelledNumbers"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_OrmapTaxlotEditing_TaxlotAssignment', the id declared for Add-in Tool class 'TaxlotAssignment'
            '''</summary>
            Friend Shared ReadOnly Property TaxlotAssignment() As String
                Get
                    Return "ORMAP_OrmapTaxlotEditing_TaxlotAssignment"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_OrmapTaxlotEditing_AddArrows', the id declared for Add-in Tool class 'AddArrows'
            '''</summary>
            Friend Shared ReadOnly Property AddArrows() As String
                Get
                    Return "ORMAP_OrmapTaxlotEditing_AddArrows"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_Annotate_CreateAnnotationButton', the id declared for Add-in Button class 'CreateAnnotationButton'
            '''</summary>
            Friend Shared ReadOnly Property CreateAnnotationButton() As String
                Get
                    Return "ORMAP_Annotate_CreateAnnotationButton"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_Annotate_TransposeAnnotationButton', the id declared for Add-in Button class 'TransposeAnnotationButton'
            '''</summary>
            Friend Shared ReadOnly Property TransposeAnnotationButton() As String
                Get
                    Return "ORMAP_Annotate_TransposeAnnotationButton"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_Annotate_InvertAnnotationButton', the id declared for Add-in Button class 'InvertAnnotationButton'
            '''</summary>
            Friend Shared ReadOnly Property InvertAnnotationButton() As String
                Get
                    Return "ORMAP_Annotate_InvertAnnotationButton"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_Annotate_MoveDownButton', the id declared for Add-in Button class 'AnnoMoveDownButton'
            '''</summary>
            Friend Shared ReadOnly Property AnnoMoveDownButton() As String
                Get
                    Return "ORMAP_Annotate_MoveDownButton"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_Annotate_StandardBothSidesDownButton', the id declared for Add-in Button class 'AnnoBothDownStandardButton'
            '''</summary>
            Friend Shared ReadOnly Property AnnoBothDownStandardButton() As String
                Get
                    Return "ORMAP_Annotate_StandardBothSidesDownButton"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_Annotate_WideBothSidesDownButton', the id declared for Add-in Button class 'AnnoBothDownWideButton'
            '''</summary>
            Friend Shared ReadOnly Property AnnoBothDownWideButton() As String
                Get
                    Return "ORMAP_Annotate_WideBothSidesDownButton"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_Annotate_MoveUpButton', the id declared for Add-in Button class 'AnnoMoveUpButton'
            '''</summary>
            Friend Shared ReadOnly Property AnnoMoveUpButton() As String
                Get
                    Return "ORMAP_Annotate_MoveUpButton"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_Annotate_StandardBothSidesUpButton', the id declared for Add-in Button class 'AnnoBothUpStandardButton'
            '''</summary>
            Friend Shared ReadOnly Property AnnoBothUpStandardButton() As String
                Get
                    Return "ORMAP_Annotate_StandardBothSidesUpButton"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_Annotate_WideBothSidesUpButton', the id declared for Add-in Button class 'AnnoBothUpWideButton'
            '''</summary>
            Friend Shared ReadOnly Property AnnoBothUpWideButton() As String
                Get
                    Return "ORMAP_Annotate_WideBothSidesUpButton"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_SpiralTools_SCS_tool', the id declared for Add-in Tool class 'SCS_tool'
            '''</summary>
            Friend Shared ReadOnly Property SCS_tool() As String
                Get
                    Return "ORMAP_SpiralTools_SCS_tool"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_SpiralTools_SingleSpiral', the id declared for Add-in Tool class 'SingleSpiral'
            '''</summary>
            Friend Shared ReadOnly Property SingleSpiral() As String
                Get
                    Return "ORMAP_SpiralTools_SingleSpiral"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_OrmapTaxlotEditing_Extension', the id declared for Add-in Extension class 'OrmapExtension'
            '''</summary>
            Friend Shared ReadOnly Property OrmapExtension() As String
                Get
                    Return "ORMAP_OrmapTaxlotEditing_Extension"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_OrmapTaxlotEditing_LocateFeatureDockWindow', the id declared for Add-in DockableWindow class 'LocateFeatureDockWindow+AddinImpl'
            '''</summary>
            Friend Shared ReadOnly Property LocateFeatureDockWindow() As String
                Get
                    Return "ORMAP_OrmapTaxlotEditing_LocateFeatureDockWindow"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_SpiralToolbar_SpiralCurveSpiralDockWindow', the id declared for Add-in DockableWindow class 'SpiralCurveSpiralDockWindow+AddinImpl'
            '''</summary>
            Friend Shared ReadOnly Property SpiralCurveSpiralDockWindow() As String
                Get
                    Return "ORMAP_SpiralToolbar_SpiralCurveSpiralDockWindow"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_SpiralToolbar_SpiralDockWindow', the id declared for Add-in DockableWindow class 'SpiralDockWindow+AddinImpl'
            '''</summary>
            Friend Shared ReadOnly Property SpiralDockWindow() As String
                Get
                    Return "ORMAP_SpiralToolbar_SpiralDockWindow"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ORMAP_OrmapTaxlotEditing_EditorExtension', the id declared for Add-in Extension class 'EditorExtension'
            '''</summary>
            Friend Shared ReadOnly Property EditorExtension() As String
                Get
                    Return "ORMAP_OrmapTaxlotEditing_EditorExtension"
                End Get
            End Property
        End Class
    End Module
    
Friend Module ArcMap
  Private s_app As ESRI.ArcGIS.Framework.IApplication
  Private s_docEvent As ESRI.ArcGIS.ArcMapUI.IDocumentEvents_Event

  Public ReadOnly Property Application() As ESRI.ArcGIS.Framework.IApplication
    Get
      If s_app Is Nothing Then
        s_app = TryCast(Internal.AddInStartupObject.GetHook(Of ESRI.ArcGIS.ArcMapUI.IMxApplication)(), ESRI.ArcGIS.Framework.IApplication)
        If s_app Is Nothing Then
          Dim editorHost As ESRI.ArcGIS.Editor.IEditor = Internal.AddInStartupObject.GetHook(Of ESRI.ArcGIS.Editor.IEditor)()
          If editorHost IsNot Nothing Then s_app = editorHost.Parent
        End If
      End If

      Return s_app
    End Get
  End Property

  Public ReadOnly Property Document() As ESRI.ArcGIS.ArcMapUI.IMxDocument
    Get
      If Application IsNot Nothing Then
        Return TryCast(Application.Document, ESRI.ArcGIS.ArcMapUI.IMxDocument)
      End If

      Return Nothing
    End Get
  End Property

  Public ReadOnly Property ThisApplication() As ESRI.ArcGIS.ArcMapUI.IMxApplication
    Get
      Return TryCast(Application, ESRI.ArcGIS.ArcMapUI.IMxApplication)
    End Get
  End Property
  Public ReadOnly Property DockableWindowManager() As ESRI.ArcGIS.Framework.IDockableWindowManager
    Get
      Return TryCast(Application, ESRI.ArcGIS.Framework.IDockableWindowManager)
    End Get
  End Property

  Public ReadOnly Property Events() As ESRI.ArcGIS.ArcMapUI.IDocumentEvents_Event
    Get
      s_docEvent = TryCast(Document, ESRI.ArcGIS.ArcMapUI.IDocumentEvents_Event)
      Return s_docEvent
    End Get
  End Property

  Public ReadOnly Property Editor() As ESRI.ArcGIS.Editor.IEditor
    Get
      Dim editorUID As New ESRI.ArcGIS.esriSystem.UID
      editorUID.Value = "esriEditor.Editor"
      Return TryCast(Application.FindExtensionByCLSID(editorUID), ESRI.ArcGIS.Editor.IEditor)
    End Get
  End Property
End Module

Namespace Internal
  <ESRI.ArcGIS.Desktop.AddIns.StartupObjectAttribute(), _
   Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
   Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
  Partial Public Class AddInStartupObject
    Inherits ESRI.ArcGIS.Desktop.AddIns.AddInEntryPoint

    Private m_addinHooks As List(Of Object)
    Private Shared _sAddInHostManager As AddInStartupObject

    Public Sub New()

    End Sub

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Protected Overrides Function Initialize(ByVal hook As Object) As Boolean
      Dim createSingleton As Boolean = _sAddInHostManager Is Nothing
      If createSingleton Then
        _sAddInHostManager = Me
        m_addinHooks = New List(Of Object)
        m_addinHooks.Add(hook)
      ElseIf Not _sAddInHostManager.m_addinHooks.Contains(hook) Then
        _sAddInHostManager.m_addinHooks.Add(hook)
      End If

      Return createSingleton
    End Function

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Protected Overrides Sub Shutdown()
      _sAddInHostManager = Nothing
      m_addinHooks = Nothing
    End Sub

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Friend Shared Function GetHook(Of T As Class)() As T
      If _sAddInHostManager IsNot Nothing Then
        For Each o As Object In _sAddInHostManager.m_addinHooks
          If TypeOf o Is T Then
            Return DirectCast(o, T)
          End If
        Next
      End If

      Return Nothing
    End Function

    ''' <summary>
    ''' Expose this instance of Add-in class externally
    ''' </summary>
    Public Shared Function GetThis() As AddInStartupObject
      Return _sAddInHostManager
    End Function

  End Class
End Namespace

End Namespace
