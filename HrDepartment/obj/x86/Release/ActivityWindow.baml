   M S B A M L   `   `   `  ����   HrDepartment!    HrDepartment.ActivityWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     k gTelerik.Windows.Documents.Core, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a
 ]Telerik.Windows.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Charting, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Maths, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Utelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
       -     � Title$M  GІнформація про діяльність працівників��$	��700��$
��1140�� � WindowStartupLocation$ CenterScreen=� � Icon$ Images/Week View-96.png��.��� .+��� $��Управління��$
��Left=�$��10,0,0,0q�$	��Top=�$	��150��$	��133��.��� .+��� -    ��Name$ 	AddButton��$
��Left=�$��5,10,0,0q�$	��Top=�$	��106��$��25��.����  �� Orientation$ 
Horizontal=�.+��� $��Images/Add File-96.png��$��20��$��20���� $��Додати��$��Center=� � ToolTip$^ XДодати дані про діяльність працівника за місяць���� -   $ UpdateButton��$
��Left=�$��	5,53,0,50q�$	��106��.���� $ 
Horizontal=�.+��� $��Images/Edit File-96.png��$��20��$��20���� $��Змінити��$��Center=�$d ^Внести зміни у відомості про діяльність працівника���� -   $ DeleteButton��$
��Left=�$��5,0,0,10q�$��Bottom=�$	��106��$��25��.���� $ 
Horizontal=�.+��� $��Images/Delete File-96.png��$��20��$��20���� $��Видалити��$��Center=�$b \Видалити дані про діяльність працівника за місяць���� $K��EВідомості про діяльність працівників��$��Stretch=�$��	148,0,5,5q�$��Stretch=�.��� .+�* 	 $Telerik.Windows.Controls.RadGridView  -     Name$ ActivityGridView��$��Stretch=�$��5,5,5,24q�$��Stretch=�; 	 5Telerik.Windows.Controls.GridView.GridViewDataControl   
IsReadOnly .    ShowGroupPanel .  	   ColumnWidth? 	 9Telerik.Windows.Controls.GridView.GridViewLengthConverter$	 * 
   FrozenColumnCount$
 3��   AutoGenerateColumns .  * 
 $Telerik.Windows.Controls.DataControl   ItemsSource �� *
Activity+   Columns 1 	 +Telerik.Windows.Controls.GridViewDataColumn  6 	 0Telerik.Windows.Controls.GridViewBoundColumnBase   Header$N HНомер запису про діяльність працівника��- 	 'Telerik.Windows.Controls.GridViewColumn   Width$
 Auto    	IsVisible .     DataMemberBinding �� *
ActivityID+  $! ПІБ працівника��$ *  �� *Fia+  $ Номер місяця��$ *  .   �� *CalendarMonth+  $ Місяць��$
 auto  �� *CalendarMonthName+  $ Рік��$
 auto  �� *CalendarYear+  $ Присутність��$
 auto  �� *	Present+  $ Відсутність��$
 Auto  �� *	Absence+  $ Лікарняний��$
 Auto  �� *
Hospital+  $ Відпустка��$
 Auto  �� *
Vacation+  $ ID працівника��$
 Auto  .   �� *ID+   GroupDescriptors * 
 $Telerik.Windows.Data.GroupDescriptor     Member$ CalendarYear��.	 
 (Telerik.Windows.Data.GroupDescriptorBase 	  SortDirection$ 	AscendingX�  $ CalendarMonthName��8
 
 2Telerik.Windows.Data.AggregatedGroupDescriptorBase 
  AggregateFunctions ( 
 "Telerik.Windows.Data.CountFunction  , 
 &Telerik.Windows.Data.AggregateFunction   Caption$) #Кількість записів: ��+  %Telerik.Windows.Controls.RadDataPager  $	��5,0q�$��bottom=�   IsTotalItemCountFixed .    PageSize$ 25��   DisplayMode$# FirstLastPreviousNextNumeric =�   Source �� *Items+ �� ElementName$ ActivityGridView���� $��Експорт��$
��Left=�$��
10,150,0,0q�$	��Top=�$	��133��$	��118��.��� .+��� $
��Left=�$��5,5,0,0q�$��NoWrap=�$��Формат файлу:��$	��Top=��� -    ��Name$ ComboBox��$��Stretch=�$��	5,26,10,0q�$	��Top=�.@��� -   $
��Xlsx�� �� 
IsSelected . .��Excel (Xlsx)�� -   $	��Pdf��.��Pdf�� -	   $ ExportButton��$
��Left=�$��5,61,0,0q�$	��Top=�$	��106��$��25��.���� $ 
Horizontal=�.+��� $��Images/Export-96.png��$��20��$��20���� $��Експортувати��$��Center=�