   M S B A M L   `   `   `  ����   HrDepartment(    "HrDepartment.AddEditPositionWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     k gTelerik.Windows.Documents.Core, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a
 ]Telerik.Windows.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Charting, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Maths, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Utelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
       -     � Title$   ��$	��234��$��465.434�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$ Images/Workers-96.png��.��� .+��� $.��(Інформація про посаду��$
��Left=�$��5,5,0,0q�$	��Top=�$	��436��$	��156��.��� .+��� -    ��Name$ PositionNameTextBox��$
��Left=�$��23��$��	92,10,0,0q� �� TextWrapping$ NoWrap=�$�� ��$	��Top=�$	��322���� $
��Left=�$��	10,14,0,0q�$��NoWrap=�$��Назва посади:��$	��Top=��� $
��Left=�$��	10,45,0,0q�$��NoWrap=�$��Код посади:��$	��Top=��� -   $ PositionCodeTextBox��$
��Left=�$��23��$��	92,42,0,0q�$ NoWrap=�$�� ��$	��Top=�$	��322���� $
��Left=�$��	10,77,0,0q�$��NoWrap=�$��Оклад:��$	��Top=��� $
��Left=�$��
10,106,0,0q�$��NoWrap=�$��Надбавка:��$	��Top=�1  +Telerik.Windows.Controls.RadMaskedTextInput  -     Name$ SalaryTextInput��1  +Telerik.Windows.Controls.RadMaskedInputBase   SelectionOnFocus$ CaretToBeginning=�   UpdateValueEvent$ 	LostFocus=�	   Mask$	 ############��$
��Left=�
   EmptyContent$*
 $Введіть суму окладу��$��	92,74,0,0q�$	��Top=�$	��322��$��23��  -   $ BonusTextInput��$ CaretToBeginning=�$ 	LostFocus=�$	 ############��$
��Left=�$.
 (Введіть суму надбавки��$��
92,103,0,0q�$	��Top=�$	��322��$��23���� -    ��Name$ 
EditButton��$��Змінити��$
��Left=�$��366,166,0,0q�$	��Top=�$��75��$��25��$y�Hidden=��� -   $ 	AddButton��$��Додати��$
��Left=�$��366,166,0,0q�$	��Top=�$��75��$��25��$y�Hidden=�