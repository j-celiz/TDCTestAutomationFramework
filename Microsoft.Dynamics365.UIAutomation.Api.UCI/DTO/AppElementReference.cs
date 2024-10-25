// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System.Collections.Generic;

namespace Microsoft.Dynamics365.UIAutomation.Api.UCI
{
    public static class AppReference
    {
        public static class Application
        {
            public static string Shell = "App_Shell";
        }

        /// <summary>
        /// Name references to XPath locators dictionary.
        /// </summary>
        public static class BusinessCentral
        {
            //---------------------------- Navigation -----------------------------------------

            public static string SearchForPage_Button = "BC_SearchForPage_Button";
            public static string AccountManagerButton = "BC_AccountManagerButton";
            public static string AccountManagerSignOutButton = "BC_AccountManagerSignOutButton";
            public static string BackButton = "BC_BackButton";
            public static string PageError_TextContainer = "BC_PageError_TextContainer";
            public static string PageError_RefreshLink = "BC_PageError_RefreshLink";
            public static string FullScreen_Button = "BC_FullScreen_Button";

            //---------------------------- Dialogs -----------------------------------------
            public static string Dialog_Button = "BC_Dialog_Button";
            public static string Dialog_TextContainer = "BC_Dialog_TextContainer";
            public static string ExceptionDialog_TextContainer = "BC_ExceptionDialog_TextContainer";
            public static string Dialog_RadioOption = "BC_Dialog_RadioOption";
            public static string DialogSearchButton = "BC_DialogSearchButton";
            public static string DialogSearchInput = "BC_DialogSearchInput";

            //---------------------------- Grid -----------------------------------------

            public static string Grid_Container = "BC_Grid_Container";
            public static string Grid_Header = "BC_Grid_Header";
            public static string Grid_RecordLink = "BC_Grid_RecordLink";
            public static string Grid_SearchIcon= "BC_Grid_SearchIcon";
            public static string Grid_SearchInput = "BC_Grid_SearchInput";
            public static string GridInputType = "BC_GridInputType";
            public static string GridInputNo = "BC_GridInputNo";
            public static string GridInputQuantity = "BC_GridInputQuantity";
            public static string GridInputQtyToShip = "BC_GridInputQtyToShip";
            public static string GridFSLIDInput = "BC_GridFSLIDInput";
            public static string GridTopRightButton = "BC_GridTopRightButton";
            public static string GridNameFSLID = "BC_GridNameFSLID";
            public static string GridTextboxEllipsis = "BC_GridTextboxEllipsis";

            //---------------------------- GlobalSearch -----------------------------------------

            public static string Search_Textfield = "BC_Search_Textfield";
            public static string Search_Results = "BC_Search_Results";
            public static string First_SearchResult = "BC_First_SearchResult";


            //---------------------------- Entity -----------------------------------------

            public static string SectionHeaderFolded = "BC_SectionHeaderFolded";
            public static string SectionHeaderFolded2 = "BC_SectionHeaderFolded2";
            public static string SectionShowMore = "BC_SectionShowMore";
            public static string SectionShowMore2 = "BC_SectionShowMore2";
            public static string TextFieldContainer = "BC_TextFieldContainer";
            public static string TextFieldContainer2 = "BC_TextFieldContainer2";
            public static string TextFieldContainer3 = "BC_TextFieldContainer3";
            public static string EditMode_Button = "BC_EditMode_Button";
            public static string ReadOnlyMode_Button = "BC_ReadOnlyMode_Button";
            public static string EntityHeader = "BC_EntityHeader";
            public static string PurchaseOrderLinkNew = "BC_PurchaseOrderLinkNew";
            public static string TopMenu = "BC_TopMenu";
            public static string TopSubmenu = "BC_TopSubmenu";
            public static string PostActionsMenu = "BC_PostActionsMenu";
            public static string PostActionsMenuItem = "BC_PostActionsMenuItem";
            public static string TopSubSubmenu = "BC_TopSubSubmenu";
            public static string TopSubSubSubmenu = "BC_TopSubSubSubmenu";
            public static string PostViaHomeNav = "BC_PostViaHomeNav";
            public static string MoreOptionsButton = "BC_MoreOptionsButton";
            public static string Actions = "BC_Actions";
            public static string ListedMenu = "BC_ListedMenu";
            public static string Other = "BC_Functions_Other";
            public static string SendConfirmationButton = "BC_SendConfirmationButton";
            public static string SendEmailButton = "BC_SendEmailButton";
            public static string EmailField = "BC_EmailField";
            public static string LineRowContainer = "BC_LineRowContainer";
            public static string LineRowContainers = "BC_LineRowContainers";
            public static string LineRowContainersOfTable = "BC_LineRowContainersOfTable";
            public static string LineHeaders = "BC_LineHeaders";
            public static string LineLinkedHeader = "BC_LineLinkedHeader";
            public static string LineTextFieldContainerEdit = "BC_LineTextFieldContainerEdit";
            public static string LineTextFieldContainerRead = "BC_LineTextFieldContainerRead";
            public static string LineOptionsShow = "BC_LineOptionsShow";
            public static string LineOptionsShowForTable = "BC_LineOptionsShowForTable";
            public static string LineOptionChoose = "BC_LineOptionChoose";
            public static string LineAdditionalCommentType = "BC_LineAdditionalCommentType";
            public static string New = "BC_New";
            public static string LineTableBody = "BC_LineTableBody";
            public static string LineMenuToggle = "BC_LineMenuToggle";
            public static string LineTopMenu = "BC_LineTopMenu";
            public static string LineTopSubmenu = "BC_LineTopSubmenu";
            public static string LineSelectors = "BC_LineSelectors";
            public static string LineSelectorByData = "BC_LineSelectorByData";
            public static string LineMoreOptionsByData = "BC_LineMoreOptionsByData";
            public static string LineMoreOptionsDelete = "BC_LineMoreOptionsDelete";
            public static string GenericField = "BC_GenericField";
            public static string TopRightMenu = "BC_TopRightMenu";
            public static string ResetFiltersButton = "BC_ResetFiltersButton";
            public static string AddFilterButton = "BC_AddFilterButton";
            public static string FilterInputButton = "BC_FilterInputButton";
            public static string FilterValueInputButton = "BC_FilterValueInputButton";
            public static string FollowWorkflowHierarchyButton = "BC_FollowWorkflowHierarchyButton";
            public static string TaskFormInputField = "BC_TaskFormInputField";
            public static string CollapseFactBoxPane = "BC_CollapseFactBoxPane";
            public static string ReviewOrUpdateButton = "BC_ReviewOrUpdateButton";

            //------------------------ Copy Sales Document --------------------------------
            public static string CopySalesDocument_DocumentType = "BC_CopySalesDocument_DocumentType";
            public static string CopySalesDocument_DocumentNo = "BC_CopySalesDocument_DocumentNo";

            //------------------------ Apply Vendor Entry --------------------------------

            public static string ApplyVendorEntry_PostingDateSortedDescending = "BC_ApplyVendorEntry_PostingDateSortedDescending";
            public static string ApplyVendorEntry_PostingDateMenu = "BC_ApplyVendorEntry_PostingDateMenu";
            public static string ApplyVendorEntry_SortDescending = "BC_ApplyVendorEntry_SortDescending";
            public static string ApplyVendorEntry_SelectRow = "BC_ApplyVendorEntry_SelectRow";
            public static string AppliesToIDEllipsis = "BC_AppliesToIDEllipsis";
            public static string SelectMore = "BC_SelectMore";
            public static string OK = "BC_OK";
            public static string Yes = "BC_Yes";
            public static string ApplyVendorEntry_DeselectRow = "BC_ApplyVendorEntry_DeselectRow";
            public static string ApplyVendorEntry_ShowTheRest = "BC_ApplyVendorEntry_ShowTheRest";
            public static string ApplyVendorEntry_Menu = "BC_ApplyVendorEntry_Menu";
            public static string ApplyVendorEntry_ReadAppliesToId = "BC_ApplyVendorEntry_ReadAppliesToId";
            public static string ModalInvoiceIsPostedAsNumber = "BC_ModalInvoiceIsPostedAsNumber";
            public static string Vendor_ledger_Entries_Amount = "BC_Vendor_ledger_Entries_Amount";

            //------------------------ Purchase Invoice --------------------------------
            public static string Posting = "BC_Posting";
            public static string Posting2 = "BC_Posting2";
            public static string Post = "BC_Post";
            public static string Post2 = "BC_Post2";
            public static string Post_Item = "BC_Post_Item";
            public static string GeneratedDocumentNumber = "BC_GeneratedDocumentNumber";
            public static string GeneratedDocumentNumberCreditMemo = "BC_GeneratedDocumentNumberCreditMemo";
            public static string Modal_WorkingOnIt_Window = "BC_Modal_WorkingOnIt_Window";
            public static string Modal_You_Cannot_Post = "BC_Modal_You_Cannot_Post";

            //------------------------ Purchase Order Line --------------------------------
            public static string Purchase_Order_Line_Quantity_Received = "BC_Purchase_Order_Line_Quantity_Received";
            public static string Purchase_Order_Line_Quantity_Received_Unedited = "BC_Purchase_Order_Line_Quantity_Received_Unedited";
            public static string Purchase_Order_General_Vendor_Invoice_Number = "BC_Purchase_Order_General_Vendor_Invoice_Number";
            public static string Purchase_Order_Title = "BC_Purchase_Order_Title";

            //------------------------ Account Reconcil --------------------------------
            public static string ARPost = "BC_ARPost";
            public static string InputStatementEndingBalance = "BC_InputStatementEndingBalance";
            public static string TextTotalBalance = "BC_TextTotalBalance";
            public static string BankAccReconEdit = "BC_BankAccReconEdit";

            //------------------------ HomePage --------------------------------

            public static string HeaderTitle = "Header_Title_Dynamics_365_Business_Central";

            //Calculate and Post GST Settlement page
            public static string OptionsStartingDate = "BC_OptionsStartingDate";
            public static string OptionsEndingDate = "BC_OptionsEndingDate";
            public static string OptionsPostingDate = "BC_OptionsPostingDate";
            public static string OptionsDocumentNo = "BC_OptionsDocumentNo";
            public static string OptionsSettlementAccount = "BC_OptionsSettlementAccount";
            public static string OptionsPostON = "BC_OptionsPostON";
            public static string OptionsPostOFF = "BC_OptionsPostOFF";

            //Print Window
            public static string PrintWindow = "BC_PrintWindow";
            public static string PrintWindow_Print = "BC_PrintWindow_Print";

            //Connections
            public static string ConnectionsShowTheRest = "BC_ConnectionsShowTheRest";
            public static string ConnectionsSearchServiceId = "BC_ConnectionsSearchServiceId";
            public static string ConnectionsOneOffProductsList = "BC_ConnectionsOneOffProductsList";
            public static string BC_ConnectionsEntryNoLastCount = "BC_ConnectionsEntryNoLastCount";


            //Dimensions
            public static string DimensionCode = "BC_DimensionCode";
            public static string DimensionValueCode = "BC_DimensionValueCode";
            public static string DimensionValueName = "BC_DimensionValueName";

            //Vendor Ledger Entries
            public static string VLE_InputBox = "BC_VLE_InputBox";
            public static string VLE_SearchIcon = "BC_VLE_SearchIcon";

            //Posted Sales Invoice
            public static string PSI_PrintSend = "BC_PSI_PrintSend";
            public static string PSI_AttachAsPDF = "BC_PSI_AttachAsPDF";
            public static string PSI_ShowAttachments = "BC_PSI_ShowAttachments";
            public static string PSI_Email = "BC_PSI_Email";
            public static string PSI_Email_Details_title = "BC_PSI_Email_Details_title";
            public static string PSI_Message = "BC_PSI_Message";
            public static string PSI_Message_field = "BC_PSI_Message_field";
            public static string PSI_Send_Email = "BC_PSI_Send_Email";

            //General
            //
            public static string GJ_Process = "BC_GJ_Process";
            public static string GJ_Import_From_Excel = "BC_GJ_Import_From_Excel";
            public static string GJ_Edit_General_Journal_title = "BC_GJ_Edit_General_Journal_title";
            public static string GJ_Template_Code_field = "BC_GJ_Template_Code_field";
            public static string GJ_Ellipsis_Excel_filename = "BC_GJ_Ellipsis_Excel_filename";
            public static string GJ_Button_Choose = "BC_GJ_Button_Choose";
            public static string GJ_Message_The_Import_Completed_Successfully = "BC_GJ_Message_The_Import_Completed_Successfully";

            //Stock Items
            public static string Items_Inventory_Value = "BC_Items_Inventory_Value";

            //GIS Addresses
            public static string GISAddressesHeader = "BC_GISAddressesHeader";
            public static string GISFSLIDFirstEntry = "BC_GISFSLIDFirstEntry";
            //Lines FSL
            public static string FSLID = "BC_FSLID";
            public static string FSLAddress = "BC_FSLAddress";
            public static string FSLIDInvalidError = "BC_FSLIDInvalidError";


        }
        public static class Navigation
        {
            public static string AreaButton = "Nav_AreaButton";
            public static string AreaMenu = "Nav_AreaMenu";
            public static string AreaMoreMenu = "Nav_AreaMoreMenu";
            public static string SubAreaContainer = "Nav_SubAreaContainer";
            public static string WebAppMenuButton = "Nav_WebAppMenuButton";
            public static string UCIAppMenuButton = "Nav_UCIAppMenuButton";
            public static string SiteMapLauncherButton = "Nav_SiteMapLauncherButton";
            public static string SiteMapLauncherCloseButton = "Nav_SiteMapLauncherCloseButton";
            public static string SiteMapAreaMoreButton = "Nav_SiteMapAreaMoreButton";
            public static string SiteMapSingleArea = "Nav_SiteMapSingleArea";
            public static string AppMenuContainer = "Nav_AppMenuContainer";
            public static string SettingsLauncherBar = "Nav_SettingsLauncherBar";
            public static string SettingsLauncher = "Nav_SettingsLauncher";
            public static string AccountManagerButton = "Nav_AccountManagerButton";
            public static string AccountManagerSignOutButton = "Nav_AccountManagerSignOutButton";
            public static string GuidedHelp = "Nav_GuidedHelp";
            public static string AdminPortal = "Nav_AdminPortal";
            public static string AdminPortalButton = "Nav_AdminPortalButton";
            public static string SearchButton = "Nav_SearchButton";
            public static string Search = "Nav_Search";
            public static string QuickLaunchMenu = "Nav_QuickLaunchMenu";
            public static string QuickLaunchButton = "Nav_QuickLaunchButton";
            public static string QuickCreateButton = "Nav_QuickCreateButton";
            public static string QuickCreateMenuList = "Nav_QuickCreateMenuList";
            public static string QuickCreateMenuItems = "Nav_QuickCreateMenuItems";
            public static string PinnedSitemapEntity = "Nav_PinnedSitemapEntity";
            public static string SitemapMenuGroup = "Nav_SitemapMenuGroup";
            public static string SitemapMenuItems = "Nav_SitemapMenuItems";
            public static string SitemapSwitcherButton = "Nav_SitemapSwitcherButton";
            public static string SitemapSwitcherFlyout = "Nav_SitemapSwitcherFlyout";
            public static string UCIAppContainer = "Nav_UCIAppContainer";
            public static string UCIAppTile = "Nav_UCIAppTile";
        }

        public static class Grid
        {
            public static string Container = "Grid_Container";
            public static string QuickFind = "Grid_QuickFind";
            public static string FirstPage = "Grid_FirstPage";
            public static string NextPage = "Grid_NextPage";
            public static string PreviousPage = "Grid_PreviousPage";
            public static string SelectAll = "Grid_SelectAll";
            public static string ShowChart = "Grid_ShowChart";
            public static string HideChart = "Grid_HideChart";
            public static string JumpBar = "Grid_JumpBar";
            public static string FilterByAll = "Grid_FilterByAll";
            public static string RowsContainerCheckbox = "Grid_RowsContainerCheckbox";
            public static string RowsContainer = "Grid_RowsContainer";
            public static string Rows = "Grid_Rows";
            public static string ChartSelector = "Grid_ChartSelector";
            public static string ChartViewList = "Grid_ChartViewList";
            public static string GridSortColumn = "Grid_SortColumn";
            public static string CellContainer = "Grid_CellContainer";
            public static string ViewSelector = "Grid_ViewSelector";
            public static string ViewContainer = "Grid_ViewContainer";
            public static string SubArea = "Grid_SubArea";

        }

        public static class Entity
        {
            public static string FormContext = "Entity_FormContainer";
            public static string FormSelector = "Entity_FormSelector";
            public static string HeaderTitle = "Entity_HeaderTitle";
            public static string HeaderContext = "Entity_HeaderContext";
            public static string Save = "Entity_Save";
            public static string TextFieldContainer = "Entity_TextFieldContainer";
            public static string TextFieldLabel = "Entity_TextFieldLabel";
            public static string TextFieldValue = "Entity_TextFieldValue";
            public static string TextFieldLookup = "Entity_TextFieldLookup";
            public static string TextFieldLookupSearchButton = "Entity_TextFieldLookupSearchButton";
            public static string TextFieldLookupMenu = "Entity_TextFieldLookupMenu";
            public static string LookupFieldExistingValue = "Entity_LookupFieldExistingValue";
            public static string LookupFieldDeleteExistingValue = "Entity_LookupFieldDeleteExistingValue";
            public static string LookupFieldExpandCollapseButton = "Entity_LookupFieldExpandCollapseButton";
            public static string LookupFieldNoRecordsText = "Entity_LookupFieldNoRecordsText";
            public static string LookupFieldResultList = "Entity_LookupFieldResultList";
            public static string LookupFieldResultListItem = "Entity_LookupFieldResultListItem";
            public static string LookupFieldHoverExistingValue = "Entity_LookupFieldHoverExistingValue";
            public static string LookupResultsDropdown = "Entity_LookupResultsDropdown";
            public static string OptionSetFieldContainer = "Entity_OptionSetFieldContainer";
            public static string TextFieldLookupFieldContainer = "Entity_TextFieldLookupFieldContainer";
            public static string RecordSetNavigator = "Entity_RecordSetNavigator";
            public static string RecordSetNavigatorOpen = "Entity_RecordSetNavigatorOpen";
            public static string RecordSetNavList = "Entity_RecordSetNavList";
            public static string RecordSetNavCollapseIcon = "Entity_RecordSetNavCollapseIcon";
            public static string RecordSetNavCollapseIconParent = "Entity_RecordSetNavCollapseIconParent";
            public static string FieldControlDateTimeContainer = "Entity_FieldControlDateTimeContainer";
            public static string FieldControlDateTimeInputUCI = "Entity_FieldControlDateTimeInputUCI";
            public static string FieldControlDateTimeTimeInputUCI = "Entity_FieldControlDateTimeTimeInputUCI";
            public static string Delete = "Entity_Delete";
            public static string Assign = "Entity_Assign";
            public static string SwitchProcess = "Entity_SwitchProcess";
            public static string CloseOpportunityWin = "Entity_CloseOpportunityWin";
            public static string CloseOpportunityLoss = "Entity_CloseOpportunityLoss";
            public static string ProcessButton = "Entity_Process";
            public static string SwitchProcessDialog = "Entity_SwitchProcessDialog";
            public static string TabList = "Entity_TabList";
            public static string Tab = "Entity_Tab";
            public static string MoreTabs = "Entity_MoreTabs";
            public static string MoreTabsMenu = "Entity_MoreTabsMenu";
            public static string SubTab = "Entity_SubTab";
            public static string EntityFooter = "Entity_Footer";
            public static string SubGridTitle = "Entity_SubGridTitle";
            public static string SubGridContents = "Entity_SubGridContents";
            public static string SubGridList = "Entity_SubGridList";
            public static string SubGridListCells = "Entity_SubGridListCells";
            public static string SubGridViewPickerButton = "Entity_SubGridViewPickerButton";
            public static string SubGridViewPickerFlyout = "Entity_SubGridViewPickerFlyout";
            public static string SubGridCommandBar = "Entity_SubGridCommandBar";
            public static string SubGridCommandLabel = "Entity_SubGridCommandLabel";
            public static string SubGridOverflowContainer = "Entity_SubGridOverflowContainer";
            public static string SubGridOverflowButton = "Entity_SubGridOverflowButton";
            public static string SubGridHighDensityList = "Entity_SubGridHighDensityList";
            public static string EditableSubGridList = "Entity_EditableSubGridList";
            public static string EditableSubGridListCells = "Entity_EditableSubGridListCells";
            public static string EditableSubGridListCellRows = "Entity_EditableSubGridListCellRows";
            public static string SubGridCells = "Entity_SubGridCells";
            public static string SubGridRows = "Entity_SubGridRows";
            public static string SubGridRowsHighDensity = "Entity_SubGridRowsHighDensity";
            public static string SubGridDataRowsEditable = "Entity_SubGridDataRowsEditable";
            public static string SubGridHeaders = "Entity_SubGridHeaders";
            public static string SubGridHeadersHighDensity = "Entity_SubGridHeadersHighDensity";
            public static string SubGridHeadersEditable = "Entity_SubGridHeadersEditable";
            public static string SubGridRecordCheckbox = "Entity_SubGridRecordCheckbox";
            public static string SubGridSearchBox = "Entity_SubGridSearchBox";
            public static string SubGridAddButton = "Entity_SubGridAddButton";
            public static string FieldLookupButton = "Entity_FieldLookupButton";
            public static string SearchButtonIcon = "Entity_SearchButtonIcon";
            public static string DuplicateDetectionWindowMarker = "Entity_DuplicateDetectionWindowMarker";
            public static string DuplicateDetectionGridRows = "Entity_DuplicateDetectionGridRows";
            public static string DuplicateDetectionIgnoreAndSaveButton = "Entity_DuplicateDetectionIgnoreAndSaveButton";
            public static string FooterStatusValue = "Entity_FooterStatusField";
            public static string FooterMessageValue = "Entity_FooterMessage";
            public static string EntityBooleanFieldRadioContainer = "Entity_BooleanFieldRadioContainer";
            public static string EntityBooleanFieldRadioTrue = "Entity_BooleanFieldRadioTrue";
            public static string EntityBooleanFieldRadioFalse = "Entity_BooleanFieldRadioFalse";
            public static string EntityBooleanFieldButtonContainer = "Entity_BooleanFieldButton";
            public static string EntityBooleanFieldButtonTrue = "Entity_BooleanFieldButtonTrue";
            public static string EntityBooleanFieldButtonFalse = "Entity_BooleanFieldButtonFalse";
            public static string EntityBooleanFieldCheckboxContainer = "Entity_BooleanFieldCheckboxContainer";
            public static string EntityBooleanFieldCheckbox = "Entity_BooleanFieldCheckbox";
            public static string EntityBooleanFieldList = "Entity_BooleanFieldList";
            public static string EntityBooleanFieldFlipSwitchLink = "Entity_BooleanFieldFlipSwitchLink";
            public static string EntityBooleanFieldFlipSwitchContainer = "Entity_BooleanFieldFlipSwitchContainer";
            public static string EntityBooleanFieldToggle = "Entity_BooleanFieldToggle";
            public static string EntityOptionsetStatusCombo = "Entity_OptionsetStatusCombo";
            public static string EntityOptionsetStatusComboButton = "Entity_OptionsetStatusComboButton";
            public static string EntityOptionsetStatusComboList = "Entity_OptionsetStatusComboList";
            public static string EntityOptionsetStatusTextValue = "Entity_OptionsetStatusTextValue";
            public static string FormMessageBar = "Entity_FormMessageBar";
            public static string FormMessageBarTypeIcon = "Entity_FormMessageBarTypeIcon";
            public static string FormNotifcationBar = "Entity_FormNotifcationBar";
            public static string FormNotifcationExpandButton = "Entity_FormNotifcationExpandButton";
            public static string FormNotifcationFlyoutRoot = "Entity_FormNotifcationFlyoutRoot";
            public static string FormNotifcationList = "Entity_FormNotifcationList";
            public static string FormNotifcationTypeIcon = "Entity_FormNotifcationTypeIcon";

            public static class Header
            {
                public static string Container = "Entity_Header";
                public static string Flyout = "Entity_Header_Flyout";
                public static string FlyoutButton = "Entity_Header_FlyoutButton";
                public static string LookupFieldContainer = "Entity_Header_LookupFieldContainer";
                public static string TextFieldContainer = "Entity_Header_TextFieldContainer";
                public static string OptionSetFieldContainer = "Entity_Header_OptionSetFieldContainer";
                public static string DateTimeFieldContainer = "Entity_Header_DateTimeFieldContainer";
            }
        }

        public static class CommandBar
        {
            public static string Container = "Cmd_Container";
            public static string ContainerGrid = "Cmd_ContainerGrid";
            public static string MoreCommandsMenu = "Cmd_MoreCommandsMenu";
            public static string Button = "Cmd_Button";
        }

        public static class Timeline
        {
            public static string SaveAndClose = "Timeline_SaveAndClose";
        }

        public static class Dashboard
        {
            public static string DashboardSelector = "Dashboard_Selector";
            public static string DashboardItem = "Dashboard_Item";
            public static string DashboardItemUCI = "Dashboard_Item_UCI";
        }

        public static class MultiSelect
        {
            public static string DivContainer = "MultiSelect_DivContainer";
            public static string InputSearch = "MultiSelect_InputSearch";
            public static string SelectedRecord = "MultiSelect_SelectedRecord";
            public static string SelectedRecordButton = "MultiSelect_SelectedRecord_Button";
            public static string SelectedOptionDeleteButton = "MultiSelect_SelectedRecord_DeleteButton";
            public static string SelectedRecordLabel = "MultiSelect_SelectedRecord_Label";
            public static string FlyoutCaret = "MultiSelect_FlyoutCaret";
            public static string FlyoutOption = "MultiSelect_FlyoutOption";
            public static string FlyoutOptionCheckbox = "MultiSelect_FlyoutOptionCheckbox";
            public static string ExpandCollapseButton = "MultiSelect_ExpandCollapseButton";
        }

        //Global Search in D365 or Search For Page in D365 Business Central
        public static class GlobalSearch
        {
            public static string CategorizedSearchButton = "Search_CategorizedSearchButton";
            public static string RelevanceSearchButton = "Search_RelevanceSearchButton";
            public static string Text = "Search_Text";
            public static string Filter = "Search_Filter";
            public static string Results = "Search_Result";
            public static string Container = "Search_Container";
            public static string EntityContainer = "Search_EntityContainer";
            public static string Records = "Search_Records";
            public static string Type = "Search_Type";
            public static string GroupContainer = "Search_GroupContainer";
            public static string FilterValue = "Search_FilterValue";
            public static string RelevanceResultsContainer = "Search_RelevanceResultsContainer";
            public static string RelevanceResults = "Search_RelevanceResults";

        }

        public static class BusinessProcessFlow
        {
            public static string NextStage_UCI = "BPF_NextStage_UCI";
            public static string Flyout_UCI = "BPF_Flyout_UCI";
            public static string NextStageButton = "BPF_NextStageButton_UCI";
            public static string SetActiveButton = "BPF_SetActiveButton";
            public static string BusinessProcessFlowFieldName = "BPF_FieldName_UCI";
            public static string BusinessProcessFlowFormContext = "BPF_FormContext";
            public static string TextFieldContainer = "BPF_TextFieldContainer";
            public static string FieldSectionItemContainer = "BPF_FieldSectionItemContainer";
            public static string TextFieldLabel = "BPF_TextFieldLabel";
            public static string BooleanFieldContainer = "BPF_BooleanFieldContainer";
            public static string BooleanFieldSelectedOption = "BPF_BooleanFieldSelectedOption";
            public static string DateTimeFieldContainer = "BPF_DateTimeFieldContainer";
            public static string FieldControlDateTimeInputUCI = "BPF_FieldControlDateTimeInputUCI";
            public static string PinStageButton = "BPF_PinStageButton";
            public static string CloseStageButton = "BPF_CloseStageButton";
        }
        public static class Dialogs
        {
            public static class CloseOpportunity
            {
                public static string Ok = "CloseOpportunityDialog_OKButton";
                public static string Cancel = "CloseOpportunityDialog_CancelButton";
                public static string ActualRevenueId = "Dialog_ActualRevenue";
                public static string CloseDateId = "Dialog_CloseDate";
                public static string DescriptionId = "Dialog_Description";
            }
            public static class CloseActivity
            {
                public static string Close = "CloseActivityDialog_CloseButton";
                public static string Cancel = "CloseActivityDialog_CancelButton";
            }
            public static string AssignDialogUserTeamLookupResults = "AssignDialog_UserTeamLookupResults";
            public static string AssignDialogOKButton = "AssignDialog_OKButton";
            public static string AssignDialogToggle = "AssignDialog_ToggleField";
            public static string ConfirmButton = "Dialog_ConfirmButton";
            public static string CancelButton = "Dialog_CancelButton";
            public static string DuplicateDetectionIgnoreSaveButton = "DuplicateDetectionDialog_IgnoreAndSaveButton";
            public static string DuplicateDetectionCancelButton = "DuplicateDetectionDialog_CancelButton";
            public static string PublishConfirmButton = "Dialog_PublishConfirmButton";
            public static string PublishCancelButton = "Dialog_PublishCancelButton";
            public static string SetStateDialog = "Dialog_SetStateDialog";
            public static string SetStateActionButton = "Dialog_SetStateActionButton";
            public static string SetStateCancelButton = "Dialog_SetStateCancelButton";
            public static string SwitchProcessDialog = "Entity_SwitchProcessDialog";
            public static string SwitchProcessDialogOK = "Entity_SwitchProcessDialogOK";
            public static string ActiveProcessGridControlContainer = "Entity_ActiveProcessGridControlContainer";
            public static string DialogContext = "Dialog_DialogContext";
            public static string SwitchProcessContainer = "Dialog_SwitchProcessContainer";
        }

        public static class QuickCreate
        {
            public static string QuickCreateFormContext = "QuickCreate_FormContext";
            public static string SaveButton = "QuickCreate_SaveButton";
            public static string SaveAndCloseButton = "QuickCreate_SaveAndCloseButton";
            public static string CancelButton = "QuickCreate_CancelButton";
        }

        public static class Lookup
        {
            public static string RelatedEntityLabel = "Lookup_RelatedEntityLabel";
            public static string ChangeViewButton = "Lookup_ChangeViewButton";
            public static string ViewRows = "Lookup_ViewRows";
            public static string LookupResultRows = "Lookup_ResultRows";
            public static string NewButton = "Lookup_NewButton";
            public static string RecordList = "Lookup_RecordList";
        }

        public static class Related
        {
            public static string CommandBarButton = "Related_CommandBarButton";
            public static string CommandBarSubButton = "Related_CommandBarSubButton";
            public static string CommandBarOverflowContainer = "Related_CommandBarOverflowContainer";
            public static string CommandBarOverflowButton = "Related_CommandBarOverflowButton";
            public static string CommandBarButtonList = "Related_CommandBarButtonList";
        }

        public static class Field
        {
            public static string ReadOnly = "Field_ReadOnly";
            public static string Required = "Field_Required";
            public static string RequiredIcon = "Field_RequiredIcon";
        }
        public static class PerformanceWidget
        {
            public static string Container = "Performance_Widget";
            public static string Page = "Performance_WidgetPage";
        }
    }

    public static class AppElements
    {
        /// <summary>
        /// XPath locators for D365 Business Central WebElements.
        /// </summary>
        public static Dictionary<string, string> Xpath = new Dictionary<string, string>()
        {
        //---------------------------- D365 Business Central -----------------------------------------

            //Navigation
            { "BC_SearchForPage_Button"             , "//*[@title='Search']"},
            { "BC_AccountManagerButton"             , "//span[text()='E']/ancestor::button" },
            { "BC_AccountManagerSignOutButton"      , "//span[text()='Sign out']" },
            { "BC_Dialog_Button"                    , "//form[@controlname='Dialog' or @role='dialog']//button[normalize-space()='[BUTTONNAME]']"},
            { "BC_Dialog_TextContainer"             , "//form[@controlname='Dialog']//div[@class='dialog-content']//p"},
            { "BC_ExceptionDialog_TextContainer"    , "//div[@class='ms-nav-exceptiondialogtitle']//span"},
            { "BC_Dialog_RadioOption"               , "//form[@role='dialog']//label[contains(text(),'[RADIOOPTION]')]/preceding-sibling::input"},
            { "BC_BackButton"                       , "//form[not(@tabindex)]//i[@data-icon-name='Back']/ancestor::button"},
            { "BC_PageError_TextContainer"          , "//form[not(@tabindex)]//div[@class='ms-nav-validationpanel-text']"},
            { "BC_PageError_RefreshLink"            , "//form[not(@tabindex)]//div[@class='ms-nav-validationpanel-text']/a"},
            { "BC_FullScreen_Button"                , "//form[not(@tabindex)]//i[@data-icon-name='FullScreen']"},
            { "BC_DialogSearchButton"              , "//form[not(@tabindex)]//button[@title='Search']"},
            { "BC_DialogSearchInput"               , "//form[not(@tabindex)]//input[@role='searchbox']"},

            //SearchForPage
            { "BC_Search_Textfield"     , "//form[@controlname='PageSearchForm']//input[@type='text']" },
            { "BC_Search_Results"       , "//form[not(@tabindex)]//div[@class='task-dialog-content ms-nav-scrollable']" },
            { "BC_First_SearchResult"       , "//div[contains(@class, 'ms-itemMain')][.//div[contains(@class, 'ms-itemName') and text() = '[KEYWORD]'] and .//div[contains(@class, 'ms-itemType') and contains(text(), '[TYPE]')]]" },

            //Grid
            { "BC_Grid_Container"       , "//form[not(@tabindex)]//table[contains(@id,'BusinessGrid')]"},
            { "BC_Grid_Header"       , "//form[not(@tabindex)]//th[@role='columnheader'][not(contains(@class,'hidden'))]/div[contains(@class, 'columncaption columncaption')]/a"},
            { "BC_Grid_RecordLink"       , "//a[@title='Open record \"[RECORDNO]\"' or @title='Select record \"[RECORDNO]\"' or @title='Show more about \"[RECORDNO]\"' or @title='Open details for \"Net Change\" \"[RECORDNO]\"']" },
            { "BC_Grid_SearchIcon", "//form[not(@tabindex)]//div[contains(@class, 'ms-SearchBox-iconContainer') and @aria-hidden='true']"},
            { "BC_Grid_SearchInput", "//form[not(@tabindex)]//input[@placeholder='Search']"},
            { "BC_GridTopRightButton", "//form[not(@tabindex)]//button[@title='[TITLE]']"},
            { "BC_GridNameFSLID", "//a[contains(@title,'[NAME]') and contains(@title,\"Sort\")]"},
            { "BC_GridTextboxEllipsis", "//a[contains(@title,'[NAME]') and contains(@class,\"MoreEllipsis\")]"},
            
            //Grid headers Input field
            { "BC_GridInputType", "//td[@controlname='Type']/select"},
            { "BC_GridInputNo", "//td[@controlname='No.']/input"},
            { "BC_GridInputQuantity", "//td[@controlname='Quantity']/input"},
            { "BC_GridInputQtyToShip", "//td[@controlname='Qty. to Ship']/input"},
            { "BC_GridFSLIDInput", "//td[@controlname='FSL ID_TSL']/input"},


            //Entity
            { "BC_EntityHeader", "//form[not(@tabindex)]//div[@role='heading' and @aria-level='2'][contains(@class,'title')]"},
            { "BC_PurchaseOrderLinkNew", "//span[text()='New']/ancestor::a[@data-is-focusable='true']"},
            { "BC_TopMenu", "//form[not(@tabindex)]//span[text()='[TITLE]']/ancestor::button[@aria-label='[TITLE]']"},
            { "BC_TopSubmenu", "//form[not(@tabindex)]//span[text()='[TITLE]']/ancestor::button"},
            { "BC_TopSubSubmenu", "//form[not(@tabindex)]//*[text()='[TITLE]']"},
            { "BC_TopSubSubSubmenu", "//div[text()='[TITLE]']"},
            { "BC_PostViaHomeNav", "//form[not(@tabindex)]//span[text()='Post' or text()='Post...']/ancestor::button\r\n"},
            { "BC_PostActionsMenu", "//form[not(@tabindex)]//button[contains(@title, 'actions for Post')]"},
            { "BC_PostActionsMenuItem", "//form[not(@tabindex)]//li//button[normalize-space()='[POSTITEM]']"},
            { "BC_MoreOptionsButton", "//form[not(@tabindex)]//div[@class='nav-bar-area-box']//span[text()='More options']"},
            { "BC_Actions", "//span[text()='Actions']"},
            { "BC_ListedMenu", "//div[@role='menu']//li//*[text()='[TITLE]']/ancestor::button"},
            { "BC_Functions_Other", "//span[text()='Other']"},
            { "BC_SendConfirmationButton", "//form[not(@tabindex)]//span[text()='OK']/parent::button"},
            { "BC_SendEmailButton", "//form[not(@tabindex)]//button[@aria-label='Send email']"},
            { "BC_EmailField", "//form[not(@tabindex)]//a[text()='To']/following-sibling::div/input"},
            { "BC_SectionHeaderFolded"        ,"//form[not(@tabindex)]//span[text()='[SECTIONNAME]']/parent::span[@aria-expanded='false']" },
            { "BC_SectionHeaderFolded2"        ,"//form[not(@tabindex)]//span[@title='[SECTIONNAME]' and @aria-expanded='false']" },
            { "BC_SectionShowMore"        ,"//form[not(@tabindex)]//span[@class='caption-text'][text()='[SECTIONNAME]']/parent::span[@aria-expanded='true']/following-sibling::button[contains(text(),'Show more')]" },
            { "BC_SectionShowMore2"        ,"//form[not(@tabindex)]//span[@title='[SECTIONNAME]' and @aria-expanded='true']/following-sibling::button[contains(text(),'Show more')]" },
            { "BC_TextFieldContainer"       , "//form[not(@tabindex)]//*[text()='[SECTIONNAME]']/../../..//div[@class='collapsibleTab' or contains(@class,'collapsible')]//a[text()='[FIELDNAME]']/parent::div[not(contains(@class,'ms-nav-hidden'))]/div/*[self::input or self::span or self::select]" },
            { "BC_TextFieldContainer2"       , "//form[not(@tabindex)]//*[text()='[SECTIONNAME]']//ancestor::div/*[contains(@class,'no-caption')]//a[text()='[FIELDNAME]']/../div/span" },
            { "BC_TextFieldContainer3"       , "//form[not(@tabindex)]//*[text()='[SECTIONNAME]']/../../..//div[@class='collapsibleTab' or contains(@class,'collapsible')]//a[text()='[FIELDNAME]']/parent::div[not(contains(@class,'ms-nav-hidden'))]/div/a" },
            { "BC_EditMode_Button", "//form[not(@tabindex)]//button[@aria-pressed='false']//i[@data-icon-name='Edit']"},
            { "BC_ReadOnlyMode_Button", "//form[not(@tabindex)]//button[@aria-pressed='true']//i[@data-icon-name='Edit']"},
            { "BC_New"       , "//form[not(@tabindex)]//button[@title='Create a new entry.'][@role='menuitem']"},
            { "BC_LineTableBody", "//form[not(@tabindex)]//tbody"},
            { "BC_GenericField", "//form[not(@tabindex)]//a[text()='[FIELDNAME]']/parent::div[not(contains(@class,'ms-nav-hidden'))]/div"},
            { "BC_TopRightMenu", "//form[not(@tabindex)]//button[@title='[TITLE]']"},
            { "BC_ResetFiltersButton", "(//form[not(@tabindex)]//div[@class='ms-nav-layout-aside-left ms-nav-layout-expanded']//a[text()='Reset filters'])[1]"},
            { "BC_AddFilterButton", "//form[not(@tabindex)]//span[text()='Filter list by:']/ancestor::button/parent::div/following-sibling::div//button"},
            { "BC_FilterInputButton", "//form[not(@tabindex)]//label[text()='Add a new filter on a field']/following-sibling::div/input"},
            { "BC_FilterValueInputButton", "//form[not(@tabindex)]//div[@controlname='[FILTERFIELD]']/input"},
            { "BC_FollowWorkflowHierarchyButton", "//form[not(@tabindex)]//div[@controlname='Follow Workflow Hierarchy_TSL']/div/div"},
            { "BC_TaskFormInputField", "//form[not(@tabindex)]//div[@controlname='[FIELDNAME]']/input"},
            { "BC_CollapseFactBoxPane", "//form[not(@tabindex)]//button[@title='Collapse the FactBox pane'][@role='menuitemcheckbox']" },
            { "BC_ReviewOrUpdateButton", "//form[not(@tabindex)]//a[text()='[FIELDNAME]']/parent::div[not(contains(@class,'ms-nav-hidden'))]/div/a[@role='button' and contains(@title, 'Review or update')]"},
            
            //Entity - Lines
            { "BC_LineRowContainer"                 , "//form[not(@tabindex)]//div[contains(@class,'ms-nav-layout-main')]//tbody/tr[@role='row'][[LINENUMBER]]/td[1]" },
            { "BC_LineRowContainers"                , "//form[not(@tabindex)]//div[contains(@class,'ms-nav-layout-main')]//tbody/tr[@role='row' and not(contains(@class,'draft-line'))]" },
            { "BC_LineRowContainersOfTable"         , "//form[not(@tabindex)]//div[contains(@class,'ms-nav-layout-main')]//div[@class='ms-nav-band-header']//*[self::div or self::a][contains(text(),'[TABLENAME]')]/ancestor::div[contains(@class,'formhost-control')]//tbody/tr[@role='row' and not(contains(@class,'draft-line'))]" },
            { "BC_LineHeaders"                      , "//form[not(@tabindex)]//div[contains(@class,'ms-nav-layout-main')]//thead[not(@aria-hidden='true')]//th[@role='columnheader' and not(contains(@class,'ms-nav-hidden'))]/div[not(contains(@class,'menuarrow'))]/*[self::a[contains(@id,'column_header')] or self::span[contains(@id,'column_header')]]" },
            { "BC_LineLinkedHeader"                 , "//form[not(@tabindex)]//div[contains(@class,'ms-nav-layout-main')]//thead[not(@aria-hidden='true')]//th[@role='columnheader' and not(contains(@class,'ms-nav-hidden'))]//a[text()='[COLUMNINDEX]']" },
            { "BC_LineTextFieldContainerEdit"       , "//form[not(@tabindex)]//div[contains(@class,'ms-nav-layout-main')]//tbody/tr[@role='row'][[LINENUMBER]]/td[(@controlname or contains(@class,'edit-container')) and not(contains(@class,'ms-nav-hidden'))][[COLUMNINDEX]]" },
            { "BC_LineTextFieldContainerRead"       , "//form[not(@tabindex)]//div[contains(@class,'ms-nav-layout-main')]//tbody/tr[@role='row'][[LINENUMBER]]/td[(@controlname or contains(@class,'edit-container')) and not(contains(@class,'ms-nav-hidden'))][[COLUMNINDEX]]//*[self::span or self::a or self::select]" },
            { "BC_LineOptionsShow"                  , "//form[not(@tabindex)]//tbody/tr[@role='row'][[LINENUMBER]]/td/a[@title='Show more options']" },
            { "BC_LineOptionsShowForTable"          , "//form[not(@tabindex)]//div[@class='ms-nav-band-header']//*[self::div or self::a][contains(text(),'[TABLENAME]')]/ancestor::div[contains(@class,'formhost-control')]//tbody/tr[@role='row'][[LINENUMBER]]/td/a[@title='Show more options']" },
            { "BC_LineOptionChoose"                 , "//div[contains(@class,'popup-menu')]//span[contains(text(),'[OPTIONNAME]')]" },
            { "BC_LineAdditionalCommentType"        , "//form[not(@tabindex)]//div[contains(@class,'ms-nav-layout-main')]//tbody/tr[@role='row'][[LINENUMBER]]/td[(@controlname or contains(@class,'edit-container')) and not(contains(@class,'ms-nav-hidden'))][2]" },  
            //TODO: There is no point in making it a toggle. BC_LineMenuToggle [TOGGLEOPTION] should be replaced with a the only useful value: More options and renamed to BC_LineMoreOptions
            { "BC_LineMenuToggle", "//form[not(@tabindex)]//div[@class='ms-nav-band-header']//span[text()='[TOGGLEOPTION]']"},
            //TODO: BC_LineTopMenu should be renamed to BC_LineMenu. The XPath needs to improved as it find both Line menu and Top menu
            { "BC_LineTopMenu", "//form[not(@tabindex)]//span[text()='[TITLE]']/ancestor::button"},
            //TODO: BC_LineTopSubmenu should be renamed to BC_LineSubmenu. The XPath needs to improved as it find both Line menu and Top menu and it's the same as the LineTopMenu
            { "BC_LineTopSubmenu", "//form[not(@tabindex)]//span[text()='[TITLE]']/ancestor::button"},
            { "BC_LineSelectors", "//form[not(@tabindex)]//div[contains(@class,'ms-nav-layout-main')]//tbody/tr[@role='row' and not(contains(@class,'draft-line'))]//td[1]"},
            { "BC_LineSelectorByData", "//form[not(@tabindex)]//div[contains(@class,'ms-nav-layout-main')]//tbody//td/a[text()='[DATAVALUE]']/../../td[@role='rowheader']"},
            { "BC_LineMoreOptionsByData", "//form[not(@tabindex)]//div[contains(@class,'ms-nav-layout-main')]//tbody//td/span[@title='[CUSTOMERNO]']/../../td[@role='gridcell']/a[@title='Show more options']"},
            { "BC_LineMoreOptionsDelete", "//form[@aria-label='Edit - Connection Suggested Invoices']//div[@role='menu']//li[@title='Delete the selected row.']"},
            
            //Copy Sales Document
            { "BC_CopySalesDocument_DocumentType"       , "//form[@controlname='Copy Sales Document']//div[@controlname='DocumentType']//select" },
            { "BC_CopySalesDocument_DocumentNo"       , "//form[@controlname='Copy Sales Document']//div[@controlname='DocumentNo']//input" },

            //Apply Vendor Entry
            { "BC_ApplyVendorEntry_PostingDateSortedDescending"     , "//form[@controlname='Apply Vendor Entries']//th[@abbr='Posting Date' and @aria-haspopup='menu' and @aria-sort='Descending']" },
            { "BC_ApplyVendorEntry_PostingDateMenu"                 , "//form[@controlname='Apply Vendor Entries']//th[@abbr='Posting Date' and @aria-haspopup='menu']" },
            { "BC_ApplyVendorEntry_SortDescending"                  , "//span[contains(text(),'Descending')]" },
            { "BC_ApplyVendorEntry_SelectRow"                       , "//table/caption[contains(text(),'Apply Vendor Entries')]/..//tr/td/a[contains(text(),'[DOCUMENTNO]')]/../../td[3]" },
            { "BC_AppliesToIDEllipsis"                              , "//a[contains(text(),'[DOCUMENTNO]')]/parent::td/preceding-sibling::td/a[contains(@title,'Show more options')]" },
            { "BC_SelectMore"                                       , "//span[text()='Select More']" },
            { "BC_OK"                                               , "//span[text()='OK']" },
            { "BC_Yes"                                              , "//span[text()='Yes']"},
            { "BC_Posting"                                          , "//form[not(@tabindex)]//span[text()='Posting']" },
            { "BC_Posting2"                                         , "//form[not(@tabindex)]//button[@aria-label='Posting']" },
            { "BC_Post"                                             , "//form[not(@tabindex)]//span[text()='Post']" },
            { "BC_Post2"                                            , "//span[text()='Post...']" },
            { "BC_PostMenu"                                         , "//button[contains(@title, 'See related actions for Post...')]" },
            { "BC_PostItem"                                         , "//form[not(@tabindex)]//li//button//span/div[text()='Post...']"},
            { "BC_ApplyVendorEntry_ShowTheRest"                     , "//form[@controlname='Apply Vendor Entries']//a[@aria-label='Show the rest']/span" },
            { "BC_ApplyVendorEntry_Menu"                            , "//main[contains(@class,'content-box')]/descendant::span[text()='[TITLE]']" },
            { "BC_ApplyVendorEntry_DeselectRow"                     , "//table/caption[contains(text(),'Apply Vendor Entries')]/..//tr[2]/td/a/../../td[1]" },
            { "BC_ApplyVendorEntry_ReadAppliesToId"                 , "//table/caption[contains(text(),'Apply Vendor Entries')]/..//tr[1]/td[3]/span" },
            { "BC_ModalInvoiceIsPostedAsNumber"                     , "//p[contains(text(),'The invoice is posted as number')]" },
            { "BC_GeneratedDocumentNumber"                     , "//p[contains(@title,'invoice')]" },
            { "BC_GeneratedDocumentNumberCreditMemo"                     , "//p[contains(@title,'credit memo')]" },
            { "BC_Modal_WorkingOnIt_Window"                     , "//span[text()='Working on it...']" },
            { "BC_Modal_You_Cannot_Post"                     , "//form[not(@tabindex)]//p[contains(text(),\"You cannot post the document of type Order with the number\")]" },
            { "BC_Vendor_ledger_Entries_Amount"                     , "//td[@controlname='Original Amount']/following-sibling::td[1]/a" },
           
            
            //Purchase Order Line
            { "BC_Purchase_Order_Line_Quantity_Received"                     , "//table[@id='BusinessGrid_byd']/tbody/tr[1]/td[19]" },
            { "BC_Purchase_Order_Line_Quantity_Received_Unedited"                     , "//tbody/tr[1]/td[19]/span" },
            { "BC_Purchase_Order_General_Vendor_Invoice_Number"                     , "//div[@controlname='Vendor Invoice No.']//input" },
            { "BC_Purchase_Order_Title"                     , "//span[text()='Purchase Order']" },

            //Copy Sales Document
            { "BC_ARPost"                                           , "//form[not(@tabindex)]//span[text()='Post']" },
            
            //Calculate and Post GST Settlement
            { "BC_OptionsStartingDate"                              , "(//input[@title='Type the date in the format d/MM/yyyy'])[1]" },
            { "BC_OptionsEndingDate"                                , "(//input[@title='Type the date in the format d/MM/yyyy'])[2]" },
            { "BC_OptionsPostingDate"                               , "(//input[@title='Type the date in the format d/MM/yyyy'])[3]" },
            { "BC_OptionsDocumentNo"                                , "//div[@controlname='DocumentNo']/descendant::input" },
            { "BC_OptionsSettlementAccount"                         , "//div[@controlname='SettlementAcc']/descendant::input" },
            { "BC_OptionsPostON"                                    , "//div[@controlname='Post']//div[@aria-checked='true']" },
            { "BC_OptionsPostOFF"                                   , "//div[@controlname='Post']//div[@aria-checked='false']" },

            //Print Window
            { "BC_PrintWindow"                                      , "//print-preview-app" },
            { "BC_PrintWindow_Print" , "print-preview-app').shadowRoot.querySelector('#sidebar').shadowRoot.querySelector('print-preview-button-strip').shadowRoot.querySelector('div > cr-button.action-button" },

            //Bank Acc. Reconciliation
            { "BC_InputStatementEndingBalance"                      , "//form[not(@tabindex)]//a[text()='Statement Ending Balance']/parent::div/descendant::input" },
            { "BC_TextTotalBalance"                                 , "//form[not(@tabindex)]//a[text()='Total Balance']/parent::div/descendant::span" },
            { "BC_BankAccReconEdit"                                 , "//i[@data-icon-name='Edit']" },

            //Connections
            { "BC_ConnectionsShowTheRest"                           , "//button[@aria-label='Show the rest']" },
            { "BC_ConnectionsSearchServiceId"                       , "//form[not(@tabindex)]/descendant::input" },
            { "BC_ConnectionsOneOffProductsList"                    , "//form[not(@tabindex)]//*[text()='Edit One-off Product']" },
            { "BC_ConnectionsEntryNoLastCount"                    , "//form[not(@tabindex)]//tbody/tr[last()]/td[12]/span" },

                        //Dimension
            { "BC_DimensionCode"                    , "//form[not(@tabindex)]//a[text()='Dimension Code']/ancestor::div[@role='grid']/descendant::a[text()='[VALUE]']" },
            { "BC_DimensionValueCode"                    , "//form[not(@tabindex)]//a[text()='Dimension Value Code']/ancestor::div[@role='grid']/descendant::a[text()='[VALUE]']" },
            { "BC_DimensionValueName"                    , "//form[not(@tabindex)]//a[text()='Dimension Value Name']/ancestor::div[@role='grid']/descendant::a[text()='[VALUE]']" },

            //Vendor Ledger Entries
            { "BC_VLE_InputBox"                    , "//form[not(@tabindex)]//input[@role='searchbox']" },
            { "BC_VLE_SearchIcon"                    , "//form[not(@tabindex)]//i[@data-icon-name='Search']" },
            

            //Posted Sales Invoice
            { "BC_PSI_PrintSend"                    , "//form[not(@tabindex)]//*[contains(text(),'Print/Send')]/ancestor::button" },
            { "BC_PSI_AttachAsPDF"                    , "//form[not(@tabindex)]//*[contains(text(),'Attach as PDF')]/ancestor::button" },
            { "BC_PSI_ShowAttachments"                    , "(//form[not(@tabindex)]//a[text()='Show Attachments'])[1]" },
            { "BC_PSI_Email"                    , "(//form[not(@tabindex)]//*[text()='Email'])[1]" },
            { "BC_PSI_Email_Details_title"                    , "//form[not(@tabindex)]//span[text()='Email Details']" },
            { "BC_PSI_Message"                    , "//form[not(@tabindex)]//div[@dir='ltr']" },
            { "BC_PSI_Message_field"                    , "//form[not(@tabindex)]//div[@dir='ltr']/descendant::p" },
            { "BC_PSI_Send_Email"                    , "//form[not(@tabindex)]//*[text()='Send Email']" },

            
            //General Journals
            { "BC_GJ_Process"                    , "//form[not(@tabindex)]//*[text()='Process']/ancestor::button" },
            { "BC_GJ_Import_From_Excel"                    , "//form[not(@tabindex)]//*[text()='Import from Excel']/ancestor::button" },
            { "BC_GJ_Edit_General_Journal_title"                    , "//form[not(@tabindex)]//*[text()='Edit - General Journal']" },
            { "BC_GJ_Template_Code_field"                    , "//form[not(@tabindex)]//*[@title='Choose a value for Template Code']/following-sibling::input" },
            { "BC_GJ_Ellipsis_Excel_filename"                    , "//form[not(@tabindex)]//*[@title='Review or update the value for Excel Filename']" },
            { "BC_GJ_Button_Choose"                    , "//form[not(@tabindex)]//*[text()='Choose...']/input" },
            { "BC_GJ_Message_The_Import_Completed_Successfully"                    , "//form[not(@tabindex)]//*[text()='The import completed successfully.']" },

            //Items stock
            { "BC_Items_Inventory_Value"                    , "//a[text()='[VALUE]' and @data-tabbable]/parent::td/following-sibling::td[@controlname='InventoryField']/a" },
              
            //GIS Address
            { "BC_GISAddressesHeader"                    , "//a[text()='[HEADER]']/parent::div/descendant::input" },
            { "BC_GISFSLIDFirstEntry"                    , "//caption[text()='GIS Address List_TSL']/parent::table//descendant::tr[@aria-rowindex='1']/descendant::a[1]" },
            { "BC_FSLID"                    , "//tbody/tr[1]/td[27]" },
            { "BC_FSLAddress"                    , "//tbody/tr[1]/td[28]" },
            { "BC_FSLIDInvalidError"                    , "//td[contains(@controlname, 'FSL')]//img[contains(@aria-label, 'FSL ID') and contains(@aria-label, 'is invalid')]" },

        //------------------------------------ D365 --------------------------------------------------

            //Application 
            { "App_Shell"    , "//*[@id=\"ApplicationShell\"]"},

            //Navigation
            { "Nav_AreaButton"       , "//button[@id='areaSwitcherId']"},
            { "Nav_AreaMenu"       , "//*[@data-lp-id='sitemap-area-switcher-flyout']"},
            { "Nav_AreaMoreMenu"       , "//ul[@role=\"menubar\"]"},
            { "Nav_SubAreaContainer"       , "//*[@data-id=\"navbar-container\"]/div/ul"},
            { "Nav_WebAppMenuButton"       , "//*[@id=\"TabArrowDivider\"]/a"},
            { "Nav_UCIAppMenuButton"       , "//a[@data-id=\"appBreadCrumb\"]"},
            { "Nav_SiteMapLauncherButton", "//button[@data-lp-id=\"sitemap-launcher\"]" },
            { "Nav_SiteMapLauncherCloseButton", "//button[@data-id='navbutton']" },
            { "Nav_SiteMapAreaMoreButton", "//button[@data-lp-id=\"sitemap-areaBar-more-btn\"]" },
            { "Nav_SiteMapSingleArea", "//li[translate(@data-text,'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz') = '[NAME]']" },
            { "Nav_AppMenuContainer"       , "//*[@id=\"taskpane-scroll-container\"]"},
            { "Nav_SettingsLauncherBar"       , "//button[@data-id='[NAME]Launcher']"},
            { "Nav_SettingsLauncher"       , "//div[@id='[NAME]Launcher']"},
            { "Nav_AccountManagerButton", "//*[@id=\"mectrl_main_trigger\"]" },
            { "Nav_AccountManagerSignOutButton", "//*[@id=\"mectrl_body_signOut\"]" },
            { "Nav_GuidedHelp"       , "//*[@id=\"helpLauncher\"]/button"},
            //{ "Nav_AdminPortal"       , "//*[@id=(\"id-5\")]"},
            { "Nav_AdminPortal"       , "//*[contains(@data-id,'officewaffle')]"},
            { "Nav_AdminPortalButton" , "//*[@id=(\"O365_AppTile_Admin\")]"},
            { "Nav_SearchButton" , "//*[@id=\"searchLauncher\"]/button"},
            { "Nav_Search",                "//*[@id=\"categorizedSearchInputAndButton\"]"},
            { "Nav_QuickLaunchMenu",                "//div[contains(@data-id,'quick-launch-bar')]"},
            { "Nav_QuickLaunchButton",                "//li[contains(@title, '[NAME]')]"},
            { "Nav_QuickCreateButton", "//button[contains(@data-id,'quickCreateLauncher')]" },
            { "Nav_QuickCreateMenuList", "//ul[contains(@id,'MenuSectionItemsquickCreate')]" },
            { "Nav_QuickCreateMenuItems", "//button[@role='menuitem']" },
            { "Nav_PinnedSitemapEntity","//li[contains(@data-id,'sitemap-entity-Pinned') and contains(@role,'treeitem')]"},
            { "Nav_SitemapMenuGroup", "//ul[@role=\"group\"]"},
            { "Nav_SitemapMenuItems", "//li[contains(@data-id,'sitemap-entity')]"},
            { "Nav_SitemapSwitcherButton", "//button[contains(@data-id,'sitemap-areaSwitcher-expand-btn')]"},
            { "Nav_SitemapSwitcherFlyout","//div[contains(@data-lp-id,'sitemap-area-switcher-flyout')]"},
            { "Nav_UCIAppContainer","//div[@id='AppLandingPageContentContainer']"},
            { "Nav_UCIAppTile", "//div[@data-type='app-title' and @title='[NAME]']"},

            
            //Grid
            { "Grid_Container"       , "//div[@data-type=\"Grid\"]"},
            { "Grid_QuickFind"       , "//*[contains(@id, \'quickFind_text\')]"},
            { "Grid_NextPage"       , "//button[contains(@data-id,'moveToNextPage')]"},
            { "Grid_PreviousPage"       , "//button[contains(@data-id,'moveToPreviousPage')]"},
            { "Grid_FirstPage"       , "//button[contains(@data-id,'loadFirstPage')]"},
            { "Grid_SelectAll"       , "//button[contains(@title,'Select All')]"},
            { "Grid_ShowChart"       , "//button[contains(@aria-label,'Show Chart')]"},
            { "Grid_JumpBar"       , "//*[@id=\"JumpBarItemsList\"]"},
            { "Grid_FilterByAll"       , "//*[@id=\"All_link\"]"},
            { "Grid_RowsContainerCheckbox"  ,   "//div[@role='checkbox']" },
            { "Grid_RowsContainer"       , "//div[contains(@role,'grid')]"},
            { "Grid_Rows"           , "//div[contains(@role,'row')]"},
            { "Grid_ChartSelector"           , "//span[contains(@id,'ChartSelector')]"},
            { "Grid_ChartViewList"           , "//ul[contains(@role,'listbox')]"},
            { "Grid_SortColumn",            "//div[@data-type='Grid']//div[@title='[COLNAME]']//div[contains(@class,'header')]"},
            { "Grid_CellContainer"    ,"//div[@role='grid'][@data-id='grid-cell-container']"},
            { "Grid_ViewSelector"   , "//span[contains(@id,'ViewSelector')]" },
            { "Grid_ViewContainer"   , "//ul[contains(@id,'ViewSelector')]" },
            { "Grid_SubArea"   , "//*[contains(@data-id,'[NAME]')]"},
            

            //Entity
            { "Entity_Assign"       , "//button[contains(@data-id,'Assign')]"},
            { "Entity_CloseOpportunityWin"       , "//button[contains(@data-id,'MarkAsWon')]"},
            { "Entity_CloseOpportunityLoss"       , "//button[contains(@data-id,'MarkAsLost')]"},
            { "Entity_Delete"       , "//button[contains(@data-id,'Delete')]"},
            { "Entity_FormContainer"       , "//*[@data-id='editFormRoot']"},
            { "Entity_FormSelector"       , "//*[@data-id='form-selector']"},
            { "Entity_HeaderTitle"       , "//*[@data-id='header_title']"},
            { "Entity_HeaderContext"       , ".//div[@data-id='headerFieldsFlyout']"},
            { "Entity_Process"       , "//button[contains(@data-id,'MBPF.ConvertTo')]"},
            { "Entity_Save"       , "//button[contains(@id, 'SavePrimary')]"},
            { "Entity_SwitchProcess"       , "//button[contains(@data-id,'SwitchProcess')]"},
            { "Entity_TextFieldContainer", ".//*[contains(@id, \'[NAME]-FieldSectionItemContainer\')]" },
            { "Entity_TextFieldLabel", ".//label[contains(@id, \'[NAME]-field-label\')]" },
            { "Entity_TextFieldValue", ".//input[contains(@data-id, \'[NAME].fieldControl\')]" },
            { "Entity_TextFieldLookup", ".//*[contains(@id, \'systemuserview_id.fieldControl-LookupResultsDropdown')]" },
            { "Entity_TextFieldLookupSearchButton", ".//button[contains(@data-id, '[NAME].fieldControl-LookupResultsDropdown_[NAME]_search')]" },
            { "Entity_TextFieldLookupMenu", "//div[contains(@data-id, '[NAME].fieldControl-LookupResultsDropdown_[NAME]') and contains(@data-id,'tabContainer')]" },
            { "Entity_LookupFieldExistingValue", ".//*[contains(@data-id, '[NAME].fieldControl-LookupResultsDropdown_[NAME]_selected_tag') and @role='link']" },
            { "Entity_LookupFieldDeleteExistingValue", ".//*[contains(@data-id, '[NAME].fieldControl-LookupResultsDropdown_[NAME]_selected_tag_delete')]" },
            { "Entity_LookupFieldExpandCollapseButton", ".//button[contains(@data-id,'[NAME].fieldControl-LookupResultsDropdown_[NAME]_expandCollapse')]/descendant::label[not(text()='+0')]" },
            { "Entity_LookupFieldNoRecordsText", ".//*[@data-id=\'[NAME].fieldControl-LookupResultsDropdown_[NAME]_No_Records_Text']" },
            { "Entity_LookupFieldResultList", ".//*[contains(@data-id, '[NAME].fieldControl-LookupResultsDropdown_[NAME]_tab')]" },
            { "Entity_LookupFieldResultListItem", ".//*[contains(@data-id, '[NAME].fieldControl-LookupResultsDropdown_[NAME]_resultsContainer')]" },
            { "Entity_LookupFieldHoverExistingValue", ".//*[contains(@data-id, '[NAME].fieldControl-LookupResultsDropdown_[NAME]_SelectedRecordList')]" },
            { "Entity_TextFieldLookupFieldContainer", ".//div[@data-id='[NAME].fieldControl-Lookup_[NAME]']" },
            { "Entity_RecordSetNavigatorOpen", "//button[contains(@data-lp-id, 'recordset-navigator')]" },
            { "Entity_RecordSetNavigator", "//button[contains(@data-lp-id, 'recordset-navigator')]" },
            { "Entity_RecordSetNavList", "//ul[contains(@data-id, 'recordSetNavList')]" },
            { "Entity_RecordSetNavCollapseIcon", "//*[contains(@data-id, 'recordSetNavCollapseIcon')]" },
            { "Entity_RecordSetNavCollapseIconParent", "//*[contains(@data-id, 'recordSetNavCollapseIcon')]" },
            { "Entity_TabList", ".//ul[contains(@id, \"tablist\")]" },
            { "Entity_Tab", ".//li[@title='{0}']" },
            { "Entity_MoreTabs", ".//div[@data-id='more_button']" },
            { "Entity_MoreTabsMenu", "//div[@id='__flyoutRootNode']" },
            { "Entity_SubTab", "//div[@id=\"__flyoutRootNode\"]//span[text()=\"{0}\"]" },
            { "Entity_FieldControlDateTimeContainer","//div[@data-id='[NAME]-FieldSectionItemContainer']" },
            { "Entity_FieldControlDateTimeInputUCI",".//*[contains(@data-id, '[FIELD].fieldControl-date-time-input')]" },
            { "Entity_FieldControlDateTimeTimeInputUCI",".//div[contains(@data-id,'[FIELD].fieldControl._timecontrol-datetime-container')]/div/div/input" },
            { "Entity_LookupResultsDropdown", "//*[contains(@data-id, '[NAME].fieldControl-LookupResultsDropdown_[NAME]_tab')]" },
            { "Entity_Footer", "//div[contains(@id,'footerWrapper')]" },
            { "Entity_SubGridTitle", "//div[contains(text(), '[NAME]')]" },
            { "Entity_SubGridContents", "//div[@id=\"dataSetRoot_[NAME]\"]" },
            { "Entity_SubGridList", ".//ul[contains(@id, \"[NAME]-GridList\")]" },
            { "Entity_SubGridListCells", ".//div[contains(@wj-part, 'cells') and contains(@class, 'wj-cells') and contains(@role, 'grid')]" },
            { "Entity_SubGridViewPickerButton", ".//span[contains(@id, 'ViewSelector') and contains(@id, 'button')]" },
            { "Entity_SubGridViewPickerFlyout", "//div[contains(@id, 'ViewSelector') and contains(@flyoutroot, 'flyoutRootNode')]" },
            { "Entity_SubGridCommandBar", ".//ul[contains(@data-id, 'CommandBar')]" },
            { "Entity_SubGridCommandLabel", ".//button//span[text()=\"[NAME]\"]" },
            { "Entity_SubGridOverflowContainer", ".//div[contains(@data-id, 'flyoutRootNode')]" },
            { "Entity_SubGridOverflowButton", ".//button[contains(@aria-label, '[NAME]')]" },
            { "Entity_SubGridHighDensityList", ".//div[contains(@data-lp-id, \"ReadOnlyGrid|[NAME]\") and contains(@class, 'editableGrid')]" },
            { "Entity_EditableSubGridList", ".//div[contains(@data-lp-id, \"[NAME]\") and contains(@class, 'editableGrid') and not(contains(@class, 'readonly'))]" },
            { "Entity_EditableSubGridListCells", ".//div[contains(@wj-part, 'cells') and contains(@class, 'wj-cells') and contains(@role, 'grid')]" },
            { "Entity_EditableSubGridListCellRows", ".//div[contains(@class, 'wj-row') and contains(@role, 'row')]" },
            { "Entity_SubGridCells",".//div[contains(@role,'gridcell')]"},
            { "Entity_SubGridRows",".//div[contains(@class,'wj-row')]"},
            { "Entity_SubGridRowsHighDensity",".//div[contains(@class,'wj-row') and contains(@role, 'row') and contains(@aria-label, 'Data')]"},
            { "Entity_SubGridDataRowsEditable",".//div[contains(@class,'wj-row') and contains(@role, 'row') and contains(@aria-label, 'Data')]"},
            { "Entity_SubGridHeaders",".//div[contains(@class,'grid-header-text')]"},
            { "Entity_SubGridHeadersHighDensity",".//div[contains(@class, 'wj-colheaders') and contains(@wj-part, 'chcells')]/div/div"},
            { "Entity_SubGridHeadersEditable",".//div[contains(@class,'wj-row') and contains(@role, 'row') and contains(@aria-label, 'Header')]/div"},
            { "Entity_SubGridRecordCheckbox","//div[contains(@data-id,'cell-[INDEX]-1') and contains(@data-lp-id,'[NAME]')]"},
            { "Entity_SubGridSearchBox",".//div[contains(@data-id, 'data-set-quickFind-container')]"},
            { "Entity_SubGridAddButton", "//button[contains(@data-id,'[NAME].AddNewStandard')]/parent::li/parent::ul[contains(@data-lp-id, 'commandbar-SubGridStandard:[NAME]')]" },
            { "Entity_FieldLookupButton","//button[contains(@data-id,'[NAME]_search')]" },
            { "Entity_SearchButtonIcon", "//span[contains(@data-id,'microsoftIcon_searchButton')]" },
            { "Entity_DuplicateDetectionWindowMarker","//div[contains(@data-id,'ManageDuplicates')]"},
            { "Entity_DuplicateDetectionGridRows", "//div[contains(@class,'data-selectable')]" },
            { "Entity_DuplicateDetectionIgnoreAndSaveButton", "//button[contains(@data-id,'ignore_save')]"},
            { "Entity_FooterStatusField",".//span[contains(@role,'status')]"},
            { "Entity_FooterMessage",".//span[contains(@data-id,'footer-message')]"},
            { "Entity_BooleanFieldRadioContainer", "//div[contains(@data-id, '[NAME].fieldControl-checkbox-container') and contains(@role,'radiogroup')]"},
            { "Entity_BooleanFieldRadioTrue", "//div[contains(@data-id, '[NAME].fieldControl-checkbox-containercheckbox-inner-second')]"},
            { "Entity_BooleanFieldRadioFalse", "//div[contains(@data-id, '[NAME].fieldControl-checkbox-containercheckbox-inner-first')]"},
            { "Entity_BooleanFieldCheckboxContainer", "//div[contains(@data-id, '[NAME].fieldControl-checkbox-container')]"},
            { "Entity_BooleanFieldCheckbox", "//input[contains(@data-id, '[NAME].fieldControl-checkbox-toggle')]"},
            { "Entity_BooleanFieldList", "//select[contains(@data-id, '[NAME].fieldControl-checkbox-select')]"},
            { "Entity_BooleanFieldFlipSwitchLink", "//div[contains(@data-id, '[NAME]-FieldSectionItemContainer')]"},
            { "Entity_BooleanFieldFlipSwitchContainer", "//div[@data-id= '[NAME].fieldControl_container']"},
            { "Entity_BooleanFieldButton", "//div[contains(@data-id, '[NAME].fieldControl_container')]"},
            { "Entity_BooleanFieldButtonTrue", ".//label[contains(@class, 'first-child')]"},
            { "Entity_BooleanFieldButtonFalse", ".//label[contains(@class, 'last-child')]"},
            { "Entity_BooleanFieldToggle", "//div[contains(@data-id, '[NAME].fieldControl-toggle-container')]"},
            { "Entity_OptionSetFieldContainer", ".//div[@data-id='[NAME].fieldControl-option-set-container']" },
            { "Entity_OptionsetStatusCombo", "//div[contains(@data-id, '[NAME].fieldControl-pickliststatus-comboBox')]"},
            { "Entity_OptionsetStatusComboButton", "//div[contains(@id, '[NAME].fieldControl-pickliststatus-comboBox_button')]"},
            { "Entity_OptionsetStatusComboList", "//ul[contains(@id, '[NAME].fieldControl-pickliststatus-comboBox_list')]"},
            { "Entity_OptionsetStatusTextValue", "//span[contains(@id, '[NAME].fieldControl-pickliststatus-comboBox_text-value')]"},
            { "Entity_FormMessageBar", "//*[@id=\"notificationMessageAndButtons\"]/div/div/span" },
            { "Entity_FormMessageBarTypeIcon", ".//span[contains(@data-id,'formReadOnlyIcon')]" },
            { "Entity_FormNotifcationBar", "//div[contains(@data-id, 'notificationWrapper')]" },
            { "Entity_FormNotifcationTypeIcon", ".//span[contains(@id,'notification_icon_')]" },
            { "Entity_FormNotifcationExpandButton", ".//span[@id='notificationExpandIcon']" },
            { "Entity_FormNotifcationFlyoutRoot", "//div[@id='__flyoutRootNode']" },
            { "Entity_FormNotifcationList", ".//ul[@data-id='notificationList']" },

            //Entity Header
            { "Entity_Header", "//div[contains(@data-id,'form-header')]"},
            { "Entity_Header_Flyout","//div[@data-id='headerFieldsFlyout']" },
            { "Entity_Header_FlyoutButton","//button[contains(@id,'headerFieldsExpandButton')]" },
            { "Entity_Header_LookupFieldContainer", "//div[@data-id='header_[NAME].fieldControl-Lookup_[NAME]']" },
            { "Entity_Header_TextFieldContainer", "//div[@data-id='header_[NAME].fieldControl-text-box-container']" },
            { "Entity_Header_OptionSetFieldContainer", "//div[@data-id='header_[NAME]']" },
            { "Entity_Header_DateTimeFieldContainer","//div[@data-id='header_[NAME]-FieldSectionItemContainer']" },
                        
            //CommandBar
            { "Cmd_Container"       , ".//ul[contains(@data-lp-id,\"commandbar-Form\")]"},
            { "Cmd_ContainerGrid"       , "//ul[contains(@data-lp-id,\"commandbar-HomePageGrid\")]"},
            { "Cmd_MoreCommandsMenu"       , "//*[@id=\"__flyoutRootNode\"]"},
            { "Cmd_Button", "//*[contains(text(),'[NAME]')]"},

            //GlobalSearch
            { "Search_RelevanceSearchButton"       , "//div[@aria-label=\"Search box\"]//button" },
            { "Search_CategorizedSearchButton"       , "//button[contains(@data-id,'search-submit-button')]" },
            { "Search_Text"       , "//input[@aria-label=\"Search box\"]" },
            { "Search_Filter"       , "//select[@aria-label=\"Filter with\"]"},
            { "Search_Container"    , "//div[@id=\"searchResultList\"]"},
            { "Search_EntityContainer"    , "//div[@id=\"View[NAME]\"]"},
            { "Search_Records"    , "//li[@role=\"row\"]" },
            { "Search_Type"       , "//select[contains(@data-id,\"search-root-selector\")]"},
            { "Search_GroupContainer", "//label[contains(text(), '[NAME]')]/parent::div"},
            { "Search_FilterValue", "//label[contains(text(), '[NAME]')]"},
            { "Search_RelevanceResultsContainer"       , "//div[@aria-label=\"Search Results\"]"},
            { "Search_RelevanceResults"       , "//li//label[contains(text(), '[ENTITY]')]"},

            //Timeline
            { "Timeline_SaveAndClose", "//button[contains(@data-id,\"[NAME].SaveAndClose\")]" },

            //MultiSelect
            { "MultiSelect_DivContainer",     ".//div[contains(@data-id,\"[NAME]-FieldSectionItemContainer\")]" },
            { "MultiSelect_InputSearch",     ".//input[contains(@class,\"msos-input\")]" },
            { "MultiSelect_SelectedRecord",  ".//li[contains(@class, \"msos-selected-display-item\")]" },
            { "MultiSelect_SelectedRecord_DeleteButton", ".//button[contains(@class, \"msos-quick-delete\")]" },
            { "MultiSelect_SelectedRecord_Label",  ".//span[contains(@class, \"msos-selected-display-item-text\")]" },
            { "MultiSelect_FlyoutOption",      "//li[label[contains(@title, \"[NAME]\")] and contains(@class,\"msos-option\")]" },
            { "MultiSelect_FlyoutOptionCheckbox", "//input[contains(@class, \"msos-checkbox\")]" },
            { "MultiSelect_FlyoutCaret", "//button[contains(@class, \"msos-caret-button\")]" },
            { "MultiSelect_ExpandCollapseButton", ".//button[contains(@class,\"msos-selecteditems-toggle\")]" },

            //Dashboard
            { "Dashboard_Selector"       , "//span[contains(@id, 'Dashboard_Selector')]"},
            { "Dashboard_Item"       , "//li[contains(@title, '[NAME]')]"},
            { "Dashboard_Item_UCI"       , "//li[contains(@data-text, '[NAME]')]"},

            //Business Process Flow
            { "BPF_NextStage_UCI"     , "//li[contains(@id,'processHeaderStage')]" },
            { "BPF_Flyout_UCI"     , "//div[contains(@id,'businessProcessFlowFlyoutHeaderContainer')]" },
            { "BPF_NextStageButton_UCI"     , "//button[contains(@data-id,'nextButtonContainer')]" },
            { "BPF_SetActiveButton", "//button[contains(@data-id,'setActiveButton')]" },
            { "BPF_FieldName_UCI"     , "//input[contains(@id,'[NAME]')]" },
            { "BPF_FieldSectionItemContainer", ".//div[contains(@id, \'header_process_[NAME]-FieldSectionItemContainer\')]" },
            { "BPF_FormContext"     , "//div[contains(@id, \'ProcessStageControl-processHeaderStageFlyoutInnerContainer\')]" },
            { "BPF_TextFieldContainer", ".//div[contains(@data-lp-id, \'header_process_[NAME]\')]" },
            { "BPF_TextFieldLabel", "//label[contains(@id, \'header_process_[NAME]-field-label\')]" },
            { "BPF_BooleanFieldContainer", ".//div[contains(@data-id, \'header_process_[NAME].fieldControl-checkbox-container\')]" },
            { "BPF_BooleanFieldSelectedOption", ".//div[contains(@data-id, \'header_process_[NAME].fieldControl-checkbox-container\') and contains(@aria-checked, \'true\')]" },
            { "BPF_DateTimeFieldContainer", ".//input[contains(@data-id, \'[NAME].fieldControl-date-time-input\')]" },
            { "BPF_FieldControlDateTimeInputUCI",".//input[contains(@data-id,'[FIELD].fieldControl-date-time-input')]" },
            { "BPF_PinStageButton","//button[contains(@id,'stageDockModeButton')]"},
            { "BPF_CloseStageButton","//button[contains(@id,'stageContentClose')]"},

            //Related Grid
            { "Related_CommandBarButton", ".//button[contains(@aria-label, '[NAME]') and contains(@id,'SubGrid')]"},
            { "Related_CommandBarOverflowContainer", "//div[contains(@data-id, 'flyoutRootNode')]"},
            { "Related_CommandBarOverflowButton", ".//button[contains(@data-id, 'OverflowButton') and contains(@data-lp-id, 'SubGridAssociated')]"},
            { "Related_CommandBarSubButton" ,".//button[contains(., '[NAME]')]"},
            { "Related_CommandBarButtonList" ,"//ul[contains(@data-lp-id, 'commandbar-SubGridAssociated')]"},

            //Field
            {"Field_ReadOnly",".//*[@aria-readonly]" },
            {"Field_Required", ".//*[@aria-required]"},
            {"Field_RequiredIcon", ".//div[contains(@data-id, 'required-icon') or contains(@id, 'required-icon')]"},

            //Dialogs
            { "AssignDialog_ToggleField" , "//label[contains(@data-id,'rdoMe_id.fieldControl-checkbox-inner-first')]" },
            { "AssignDialog_UserTeamLookupResults" , "//ul[contains(@data-id,'systemuserview_id.fieldControl-LookupResultsDropdown_systemuserview_id_tab')]" },
            { "AssignDialog_OKButton" , "//button[contains(@data-id, 'ok_id')]" },
            { "CloseOpportunityDialog_OKButton" , "//button[contains(@data-id, 'ok_id')]" },
            { "CloseOpportunityDialog_CancelButton" , "//button[contains(@data-id, 'cancel_id')]" },
            { "CloseActivityDialog_CloseButton" , ".//button[contains(@data-id, 'ok_id')]" },
            { "CloseActivityDialog_CancelButton" , ".//button[contains(@data-id, 'cancel_id')]" },
            { "Dialog_DialogContext", "//div[contains(@role, 'dialog')]" },
            { "Dialog_ActualRevenue", "//input[contains(@data-id,'actualrevenue_id')]" },
            { "Dialog_CloseDate", "//input[contains(@data-id,'closedate_id')]" },
            { "Dialog_DescriptionId", "//input[contains(@data-id,'description_id')]" },
            { "Dialog_ConfirmButton" , "//*[@id=\"confirmButton\"]" },
            { "Dialog_CancelButton" , "//*[@id=\"cancelButton\"]" },
            { "DuplicateDetectionDialog_IgnoreAndSaveButton" , "//button[contains(@data-id, 'ignore_save')]" },
            { "DuplicateDetectionDialog_CancelButton" , "//button[contains(@data-id, 'close_dialog')]" },
            { "Dialog_SetStateDialog" , "//div[@data-id=\"SetStateDialog\"]" },
            { "Dialog_SetStateActionButton" , ".//button[@data-id=\"ok_id\"]" },
            { "Dialog_SetStateCancelButton" , ".//button[@data-id=\"cancel_id\"]" },
            { "Dialog_PublishConfirmButton" , "//*[@data-id=\"ok_id\"]" },
            { "Dialog_PublishCancelButton" , "//*[@data-id=\"cancel_id\"]" },
            { "Dialog_SwitchProcessContainer" , "//div[contains(@id,'switchProcess_id-FieldSectionItemContainer')]" },
            { "Entity_ActiveProcessGridControlContainer"       , "//div[contains(@data-lp-id,'activeProcessGridControlContainer')]"},
            { "Entity_SwitchProcessDialogOK"       , "//button[contains(@data-id,'ok_id')]"},
            { "SwitchProcess_Container" , "//section[contains(@id, 'popupContainer')]" },
			
            //QuickCreate
            { "QuickCreate_FormContext" , "//section[contains(@data-id,'quickCreateRoot')]" },
            { "QuickCreate_SaveButton" , "//button[contains(@id,'quickCreateSaveBtn')]" },
            { "QuickCreate_SaveAndCloseButton", "//button[contains(@id,'quickCreateSaveAndCloseBtn')]"},
            { "QuickCreate_CancelButton", "//button[contains(@id,'quickCreateCancelBtn')]"},

            //Lookup
            { "Lookup_RelatedEntityLabel", "//li[contains(@aria-label,'[NAME]') and contains(@data-id,'LookupResultsDropdown')]" },
            { "Lookup_ChangeViewButton", "//button[contains(@data-id,'changeViewBtn')]"},
            { "Lookup_ViewRows", "//li[contains(@data-id,'viewLineContainer')]"},
            { "Lookup_ResultRows", "//li[contains(@data-id,'LookupResultsDropdown') and contains(@data-id,'resultsContainer')]"},
            { "Lookup_NewButton", "//button[contains(@data-id,'addNewBtnContainer') and contains(@data-id,'LookupResultsDropdown')]" },
            { "Lookup_RecordList", ".//div[contains(@id,'RecordList') and contains(@role,'presentation')]" },

            //Performance Width
            { "Performance_Widget","//div[@data-id='performance-widget']//*[text()='Page load']"},
            { "Performance_WidgetPage", "//div[@data-id='performance-widget']//span[contains(text(), '[NAME]')]" },

            //HomePage
            { "Header_Title_Dynamics_365_Business_Central", "//span[text()='Dynamics 365 Business Central']" }

        };
    }

    public enum LoginResult
    {
        Success,
        Failure,
        Redirect
    }
}