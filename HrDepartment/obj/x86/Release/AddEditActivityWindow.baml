   M S B A M L   `   `   `  ����   HrDepartment(    "HrDepartment.AddEditActivityWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     k gTelerik.Windows.Documents.Core, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a
 ]Telerik.Windows.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Charting, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Maths, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Utelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
       -     � Title$   ��$��347.667��$��334.124�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$ Images/Week View-96.png��.��� $	��323��$	��Top=�$��0,0,0,-4q�.+��� $K��EІнформація про діяльність працівника��$
��Left=�$��10,5,0,0q�$	��Top=�$	��302��$	��264��.��� .+��� $
��Left=�$��	10,10,0,0q�$��NoWrap=�$"��ПІБ працівника:��$	��Top=��� -    ��Name$ FiaComboBox��$
��Left=�$��	10,31,0,0q�$	��Top=�$	��269������ �� $
��Left=�$��	10,58,0,0q�$��NoWrap=�$��Місяць:��$	��Top=��� -   $ MonthComboBox��$
��Left=�$��	10,79,0,0q�$	��Top=�$	��157��.@��� -   $��Item1��
 � Tag$ 1�� �� 
IsSelected . .��Січень�� -   $��Item2��$ 2��.��
Лютий�� -   $��Item3��$ 3��.��Березень�� -   $��Item4��$ 4��.��Квітень�� -   $��Item5��$ 5��.��Травень�� -	   $��Item6��$ 6��.��Червень�� -
   $��Item7��$ 7��.��Липень�� -   $��Item8��$ 8��.��Серпень�� -   $��Item9��$ 9��.��Вересень�� -   $��Item10��$ 10��.��Жовтень�� -   $��Item11��$ 11��.��Листопад�� -   $��Item12��$ 12��.��Грудень�� $
��Left=�$��
172,58,0,0q�$��NoWrap=�$��Рік:��$	��Top=�/  )Telerik.Windows.Controls.RadNumericUpDown  -     Name$ YearNumericUpDown��$
��Left=�$��
172,79,0,0q�$	��Top=�$	��107��   
IsEditable . +  %Telerik.Windows.Controls.RadRangeBase	   Minimum$
	 2010Q�
   Maximum$

 2100Q�   Value$
 2016X�   HideTrailingZeros . �� -   $��
Separator1��$��38,106,38,129q� J� RenderTransformOrigin$ 0.5,0.5&��� $
��Left=�$��
10,121,0,0q�$��NoWrap=�$$��Присутній (днів):��$	��Top=�  -   $ PresentNumericUpDown��$
��Left=�$��127,118,0,0q�$	��Top=�$	��152�� . $	 0Q�$
 31Q� . �� $
��Left=�$��
10,151,0,0q�$��NoWrap=�$$��Відсутній (днів):��$	��Top=�  -   $ AbsenceNumericUpDown��$
��Left=�$��127,148,0,0q�$	��Top=�$	��152�� . $	 0Q�$
 31Q� . �� $
��Left=�$��
10,178,0,0q�$��NoWrap=�$&�� Лікарняний (днів):��$	��Top=�  -   $ HospitalNumericUpDown��$
��Left=�$��127,175,0,0q�$	��Top=�$	��152�� . $	 0Q�$
 31Q� . �� $
��Left=�$��
10,205,0,0q�$��NoWrap=�$$��Відпустка (днів):��$	��Top=�  -   $ VacationNumericUpDown��$
��Left=�$��127,202,0,0q�$	��Top=�$	��152�� . $	 0Q�$
 31Q� . �� -    ��Name$ 	AddButton��$��Додати��$
��Left=�$��236,274,0,0q�$	��Top=�$��75��$��25��$y�Hidden=��� -   $ ChangeButton��$��Змінити��$
��Left=�$��236,274,0,0q�$	��Top=�$��76��$��25��$y�Hidden=��� -    ��Name$ 	TextBlock��$
��Left=�$��
10,274,0,0q�$
��Wrap=�$�� ��$	��Top=�