   M S B A M L   `   `   `  ����   HrDepartment)    #HrDepartment.StatisticsWorkerWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     k gTelerik.Windows.Documents.Core, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a
 ]Telerik.Windows.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Charting, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Maths, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Utelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
       -     � Title$C  =Статистика по кожному працівнику��$	��600��$
��1100�� � WindowStartupLocation$ CenterScreen=� � Icon$$ Images/Positive Dynamic-96.png��.��� .+��� $��
Опції��$
��Left=�$��5,0,0,0q�$	��Top=�$	��222��$	��261��.��� .+��� $
��Left=�$��	11,61,0,0q�$��NoWrap=�$��Рік:��$	��Top=�/  )Telerik.Windows.Controls.RadNumericUpDown  -     Name$ NumericUpDown��$
��Left=�$��	99,58,0,0q�$	��Top=�$	��143��   
IsEditable . +  %Telerik.Windows.Controls.RadRangeBase   Minimum$
 2010Q�   Maximum$
 2050Q�   Value$
 2015X�   HideTrailingZeros . �� $
��Left=�$��	11,85,0,0q�$��NoWrap=�$;��5Оберіть критерій діяльності:��$	��Top=�$	��187���� -   	 ��Name$	 CriteriaComboBox��$
��Left=�$��
11,106,0,0q�$	��Top=�$	��231��.@��� -   $��Present��
 �� 
IsSelected
 . .��Присутність�� -   $��Absence��.��Відсутність�� -   $��Hospital��.��Лікарняний�� -   $��Vacation��.��Відпустка�� -    ��Name$ CreateButton��$��Вивести��$
��Left=�$��167,133,0,0q�$	��Top=�$��75��$��25���� -	   $��
Separator1��$��11,163,9,32q� J� RenderTransformOrigin$ 0.506,0.373&��� -
   $ CloseButton��$��Закрити��$
��Left=�$��167,173,0,0q�$	��Top=�$��75��$��25���� $
��Left=�$��	11,10,0,0q�$��NoWrap=�$	��Top=�$��71���� $�Працівник���� $�:���� -   $	 FiaComboBox��$
��Left=�$��	10,31,0,0q�$	��Top=�$	��232������ �� $��Експорт��$
��Left=�$��	5,227,0,0q�$	��Top=�$	��261��$	��105��.��� .+��� $
��Left=�$��5,5,0,0q�$��NoWrap=�$��Формат файлу:��$	��Top=��� -   $	 ComboBox��$��Stretch=�$��	5,26,10,0q�$	��Top=�.@��� -   $	��Png��
 . .��Png�� -   $��ExcelMl��.��	ExcelMl�� -   $	��Xps��.��Xps�� -   $ ExportButton��$
��Left=�$��
133,53,0,0q�$	��Top=�$	��106��$��25��.����  �� Orientation$ 
Horizontal=�.+��� $��Images/Export-96.png��$��20��$��20���� $��Експортувати��$��Center=�'  !Telerik.Windows.Controls.RadChart  -     Name$ Chart��$�� ��$
��Left=�$��	271,5,0,0q�$	��Top=�$
��Auto��   DefaultView 8  2Telerik.Windows.Controls.Charting.ChartDefaultView     	ChartArea 1  +Telerik.Windows.Controls.Charting.ChartArea     NoDataString$F @Не знайдено даних для відображення��   ChartLegend 3  -Telerik.Windows.Controls.Charting.ChartLegend  $��Позначення��