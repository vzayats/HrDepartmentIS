   M S B A M L   `   `   `  ����   HrDepartment    HrDepartment.SearchWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     k gTelerik.Windows.Documents.Core, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a
 ]Telerik.Windows.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Charting, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Maths, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Utelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
       -     � Title$'  !Пошук працівників��$	��692��$��1167.713�� � WindowStartupLocation$ CenterScreen=� � Icon$ Images/Search-100.png�� +� FocusedElement ��  �� ElementName$ SearchButton��.��� .+�'  !Telerik.Windows.Controls.GroupBox  $<��6Параметри пошуку працівників��$
��Left=�$	��Top=�$	��191��$	��479��$��5,5,0,0q�.��� .+��� $
��Left=�$��	10,10,0,0q�$��NoWrap=�$��Прізвище:��$	��Top=��� -    ��Name$ SurnameTextBox��$
��Left=�$��23��$��	95,10,0,0q� �� TextWrapping$ NoWrap=�$�� ��$	��Top=�$	��365���� $
��Left=�$��	10,45,0,0q�$��NoWrap=�$��Ім'я:��$	��Top=� J� RenderTransformOrigin$ 0.478,1.062&��� -   $ NameTextBox��$
��Left=�$��23��$��	95,45,0,0q�$ NoWrap=�$�� ��$	��Top=�$	��365���� $
��Left=�$��	10,84,0,0q�$��NoWrap=�$��По-батькові:��$	��Top=��� -   $ MiddleNameTextBox��$
��Left=�$��22��$��	95,82,0,0q�$ NoWrap=�$�� ��$	��Top=�$	��365���� -    ��Name$ SearchButton��$��
Пошук��$
��Left=�$��382,138,0,0q�$	��Top=�$��75��$��24���� -   $ CloseButton��$��Закрити��$
��Left=�$��
10,138,0,0q�$	��Top=�$��75��$��24���� -   $ ExportButton��$��Експорт��$
��Left=�$��302,138,0,0q�$	��Top=�$��75��$��24���� -   	 ��Name$	 ContractCheckBox��$0��*Пошук серед звільнених��$
��Left=�$��
10,114,0,0q�$	��Top=�  $'��!Результати пошуку��$��Stretch=�$��	5,201,5,5q�$��Stretch=�.��� .+�* 	 $Telerik.Windows.Controls.RadGridView  -	   
  Name$
 SearchGridView��$��stretch=�$��4,4,4,27q�$	��Top=�; 	 5Telerik.Windows.Controls.GridView.GridViewDataControl   AutoGenerateColumns .     ColumnWidth? 	 9Telerik.Windows.Controls.GridView.GridViewLengthConverter$ *    FrozenColumnCount$ 1��   ShowGroupPanel .  * 
 $Telerik.Windows.Controls.DataControl   ItemsSource �� *	Workers+   Columns 1 	 +Telerik.Windows.Controls.GridViewDataColumn  6 	 0Telerik.Windows.Controls.GridViewBoundColumnBase   Header$ ПІБ��- 	 'Telerik.Windows.Controls.GridViewColumn   Width$ *    DataMemberBinding �� *Fia+  $ Відділ��$ *  �� *DepartmentName+  $ Посада��$
 auto  �� *
Position+  $# Дата народження��   DataFormatString$  {0:d}��$
 auto  �� *	BirthDate+  $# Робочий телефон��$
 auto  �� *	WorkPhone+  $' !Мобільний телефон��$
 auto  �� *MobileNumber++	  %Telerik.Windows.Controls.RadDataPager	  $��
15,0,15,10q�$��bottom=� 	  IsTotalItemCountFixed .  	  PageSize$ 25�� 	  DisplayMode$" FirstLastPreviousNextNumeric=� 	  Source �� *Items+$ SearchGridView��