   M S B A M L   `   `   `  ����T  PWarehouseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:WarehouseManagementSystem.ViewsWarehouseManagementSystem.Views  5   	   7    1WarehouseManagementSystem.Views.AddProductsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:WarehouseManagementSystem.Views     5   	     � Title$!  Добавить товар��5      $	��421��6   $	��600��6+    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M    � ShowInTaskbar .   � 	Resources 5
       "  RoundedComboBoxControlTemplate �� 
TargetType ��Name �� CornerRadius   RoundedButtonControlTemplate��%0  &	        &	 i     �� 5   
   " ��6A   .R�5      �� $ Border��6@   #��z��6   #��z��6Q   $ 6��6�   5      �� 5   
   " ��6   .R�5      �� $ Border��6A   #��z��6   #��z��6R   $ 6��6�   ._�5      �� #��z��6#   $��Center=�6G   $��Center=�6d   5      5      5      .��5      �� ���#8a8e8e$ 15��6#   ._�5   
   ]� ���#8a8e8e.+�5      � $
��Left=�6   $	��250��6)   ���#8a8e8e.+�5      �� $!��Добавить товар��6   
�������$��Right=�6I   $	��Top=�6f   $��Center=�6   $��54��6�   $	��250��6�   $��30(�6�   $
��Bold"�6�   �� 5      $��Товар:��6   
�������$��15(�6<   $
��Left=�6K   $��	10,71,0,0q�6f   $	��Top=�6y   $��99��6�   $��30��6�    J� RenderTransformOrigin$ 	0.536,0.7&�6�   �� 5      	 �� DisplayMemberPath$
	 Name��6<   $
��Left=�6}   $��
10,106,0,0q�6�   $	��Top=�6�   $	��181��6�   $��27��6�   
 �� 
IsReadOnly
 . ��6   �� *
Products+ �� SelectedItem 6U   �� *Detail.Product+6�   �� 5      -   5         ��Name$ btnSave��5   �   #��[ 68   $��15(�6q   $��Добавить��6�   ���#6accbd$
��Left=�6�   $��
12,223,0,0q�6�   $	��Top=�6�   $	��179��6  $��33��6  ��6   �� *
AddCommand+6  �� 5      $��Количество��6   
�������$��15(�6@   $
��Left=�6O   $��
10,129,0,0q�6j   $	��Top=�6~   $	��104��6�   $��30��6�   �� 5      $��30��6;   $��10,164,17,0q�6G    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $ 0.434,2.311&�6�   ��6   �� *Detail.Quantity+6�   �� 5      -   5        $ btnSave_Copy��5   �   #��[ 6;   $��15(�6t   
���  ��$��Удалить��6�   ���#6accbd$
��Left=�6�   $��
12,261,0,0q�6�   $	��Top=�6  $	��179��6  $��33��6%  ��6   �� *DeleteCommand+6%  �� 5      -   5        $ btnSave_Copy1��5   �   #��[ 69   $��15(�6r   $��Выполнить��6�   ���#6accbd$
��Left=�6�   $��
12,299,0,0q�6�   $	��Top=�6�   $	��179��6
  $��33��6  ��6   �� *DoneCommand+6  �� 5       -   5        $ btnSave_Copy2��5    �   #��[ 6;   $��15(�6t   $��
Назад��6�   ���#6accbd$
��Left=�6�   $��
12,337,0,0q�6�   $	��Top=�6�   $	��179��6  $��33��6  ��6   �� *CancelCommand+6  5!      � 5%      $��Right=�6   ���#6accbd.+�5&      �� $ 0.5,0.5&�6;   ��6   �� *	Details+ 6[   �� *SelectedDetail+ �� View 5'      �� 5(      .P�5)      �� $��
Товар��6-    �� Width$	 200��6j    �� DisplayMemberBinding 6<   �� *Product.Name+6j   �� 5*      $��Количество��6-   $	 160��6k    6A   �� *
Quantity+6k   5+      5-      5.      5/      50      51      