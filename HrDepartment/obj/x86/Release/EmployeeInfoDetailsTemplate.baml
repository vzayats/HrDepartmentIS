   M S B A M L   `   `   `  ����   HrDepartment.    (HrDepartment.EmployeeInfoDetailsTemplate   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     k gTelerik.Windows.Documents.Core, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a
 ]Telerik.Windows.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Charting, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Maths, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Utelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
       $��406.5��.��� $	��801��$��Center=�$��-308,0,-193,46q�  � RowDefinitions  �� $��20 ��� $��20 ��� $��20 ��� $��20 ��� $��20 ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� $
��Auto ��� $	��150 ��� $��30 ��� $
��Auto ��� $��* �.+��� $��0��$��6��$��0��$��Center=�$��Stretch=�$	��100��$	��100��$
��15,0q�$��1q� �� CornerRadius$ 1��._��� ._��� -   $��WorkerImage��$��Uniform=�$��-18,3,0,-42q����� *Data+�� $��Прізвище: ��$��5,0,0,0q�$
��Bold"�$��1��$��1��$��Center=�$
��Left=��� $��5,0,0,0q�$��1��$��2��$��Center=�$
��Left=����� *	Surname+�� $��	Ім'я: ��$��5,0,0,0q�$
��Bold"�$��2��$��1��$
��Left=�$��Center=��� $��5,0,0,0q�$��2��$��2��$��Center=�$
��Left=����� *Name+�� $��Посада: ��$��5,0,0,0q�$
��Bold"�$��3��$��1��$
��Left=�$��Center=��� $��5,0,0,0q�$��3��$��2��$��Center=�$
��Left=����� *
Position+�� $!��Сімейний стан: ��$��5,0,0,0q�$
��Bold"�$��4��$��1��$
��Left=�$��Center=��� $��5,0,0,0q�$��4��$��2��$
��Left=�$��Center=����� *FamilyStatus+�� $��3��$��0��$��6��$��1��$��Stretch=�$
��Left=�$
��0,10q��� $'��!Домашній телефон: ��$��5,0,0,0q�$
��Bold"�$��2��$��4��$
��Left=�$��Center=��� $��5,0,0,0q�$��2��$��5��$
��Left=�$��Center=����� *	HomePhone+�� $#��Дата прийняття: ��$��5,0,0,0q�$
��Bold"�$��1��$��4��$
��Left=�$��Center=��� $��5,0,0,0q�$��1��$��5��$
��Left=�$��Center=����� *
HiringDate+ �� StringFormat$ {0:d}���� $#��Домашня адреса: ��$��5,0,0,0q�$
��Bold"�$��3��$��4��$
��Left=�$��Center=���  �� Orientation$ 
Horizontal=�$��3��$��5��$
��Left=�$	��Top=�$��2��$��0,3,0,0q�.+��� $��5,0,0,0q����� *	Address+�� $'��!Електронна пошта: ��$��5,3,0,2q�$
��Bold"�$��4��$��4��$
��Left=�$��Center=��� $ 
Horizontal=�$��4��$��5��$
��Left=�$	��Top=�$��0,3,0,0q�.+��� $��5,0,0,0q����� *Email+