   M S B A M L   `   `   `  ����   HrDepartment    HrDepartment.CvWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     k gTelerik.Windows.Documents.Core, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a
 ]Telerik.Windows.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Charting, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Maths, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Utelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
       -     � Title$6  0Перегляд нових кандидатів��$	��700��$
��1100�� � WindowStartupLocation$ CenterScreen=� � Icon$ Images/Cv.png��.��� .+��� $��Управління��$
��Left=�$��10,0,0,0q�$	��Top=�$	��150��$	��133��.��� .+��� -    ��Name$ 	AddButton��$
��Left=�$��5,10,0,0q�$	��Top=�$	��106��$��25��.����  �� Orientation$ 
Horizontal=�.+��� $��Images/Add File-96.png��$��20��$��20���� $��Додати��$��Center=� � ToolTip$2 ,Додати нового кандидата���� -   $ UpdateButton��$
��Left=�$��	5,53,0,50q�$	��106��.���� $ 
Horizontal=�.+��� $��Images/Edit File-96.png��$��20��$��20���� $��Змінити��$��Center=�$C =Внести зміни в дані про кандидата���� -   $ DeleteButton��$
��Left=�$��5,0,0,10q�$��Bottom=�$	��106��$��25��.���� $ 
Horizontal=�.+��� $��Images/Delete File-96.png��$��20��$��20���� $��Видалити��$��Center=�$) #Видалити кандидата���� $t��nІнформація про кандидатів на вакантні посади та їхні резюме��$��Stretch=�$��	148,0,5,5q�$��Stretch=�.��� .+�* 	 $Telerik.Windows.Controls.RadGridView  -     Name$ CandidatesGridView��$��Stretch=�$��5,5,5,5q�$��Stretch=�; 	 5Telerik.Windows.Controls.GridView.GridViewDataControl   
IsReadOnly .    ShowGroupPanel .  	   ColumnWidth? 	 9Telerik.Windows.Controls.GridView.GridViewLengthConverter$	 * 
   FrozenColumnCount$
 3��   AutoGenerateColumns .  * 
 $Telerik.Windows.Controls.DataControl   ItemsSource �� *
Candidates+   Columns 1 	 +Telerik.Windows.Controls.GridViewDataColumn  6 	 0Telerik.Windows.Controls.GridViewBoundColumnBase   Header$# Номер кандидата��- 	 'Telerik.Windows.Controls.GridViewColumn   Width$
 Auto    	IsVisible .     DataMemberBinding �� *CvID+  $0 *Назва вакантної посади��$ *  �� *	Vacancy+  $ ПІБ кандидата��$ *  �� *CandidateName+  $! Дата додавання��   DataFormatString$  {0:d}��$
 auto  �� *	AddDate+     Header$% Резюме кандидата��   CellTemplate �� .R�(  "Telerik.Windows.Controls.RadButton    Name$ 
OpenButton��-   $��Відкрити���� $��Експорт��$
��Left=�$��
10,150,0,0q�$	��Top=�$	��133��$	��118��.��� .+��� $
��Left=�$��5,5,0,0q�$��NoWrap=�$��Формат файлу:��$	��Top=��� -    ��Name$ ComboBox��$��Stretch=�$��	5,26,10,0q�$	��Top=�.@��� -   $
��Xlsx�� �� 
IsSelected . .��Excel (Xlsx)�� -	   $	��Pdf��.��Pdf�� -
   $ ExportButton��$
��Left=�$��5,61,0,0q�$	��Top=�$	��106��$��25��.���� $ 
Horizontal=�.+��� $��Images/Export-96.png��$��20��$��20���� $��Експортувати��$��Center=�