   M S B A M L   `   `   `  ����T  PWarehouseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:WarehouseManagementSystem.Helpers!WarehouseManagementSystem.Helpers  5   	   1    +WarehouseManagementSystem.Views.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >ff/clr-namespace:WarehouseManagementSystem.Helpers     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$  Авторизация��5	   	   $	��324��6   $	��497��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � 	Resources 5
       �� 
TargetType    RoundedButtonControlTemplate ��Name �� CornerRadius��%�   &	        �� 5   
   " ��6   .R�5      �� $ Border��6A   #��z��6   ���#6accbd#��z��6g   $ 6��6�   ._�5      �� #��z��6#   $��Center=�6G   $��Center=�6d   5      5      5      .��5      �� ���#8a8e8e._�5   
   � $	��285��6   $	��Top=�6    � ColumnDefinitions 5      �� 5      $	��23* �6#   �� 5      $��6* �6#   �� 5      $	��14* �6#   �� 5      $
��251* �6#   �� 5      $
��196* �6#   .+�5      �� $��Center=�6   $8��2Система Управления Складом��68   
�������$��25(�6q   $
��Left=�6   $��10,10,-0.6,0q�6�   $	��Top=�6�   $	��481��6�   $��56��6�    J� RenderTransformOrigin$ 0.517,0.278&�6�   $��5��6  �� 5      $��Почта:��6   $
��Left=�6%   
�������$��15(�6S   $��28.8,71,0,0q�6a   $	��Top=�6v   $��99��6�   $��3��6�   �� 5      $��Пароль:��6   $
��Left=�6&   
�������$��15(�6T   $��29.395,150,0,0q�6b   $	��Top=�6z   $��99��6�   $��3��6�   �� 5!      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Введите почту��69   $��1��6h   ���#8a8e8e
�������$	��2.5q�6�   $��30��6�   $��28.8,101,59.4,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $��2��6  $��3��6  ��6   �� *CurrentUser.Email+6  G� 5"      -   5         G�Name$ PasswordBox��5"   O   ���#8a8e8e$��2��6/   
�������$!	 Введите пароль��6d   <   6WarehouseManagementSystem.Helpers.PasswordBoxAssistant   BindPassword . $	��2.5q�6�   $��28.8,180,60.4,75q�6U  $��2��6o  $��3��6�     BoundPassword 6�   ��  �� Path$ CurrentUser.Password� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�  �� 5#       �� 	IsDefault . #��[  6I   $"��Авторизоваться��6�   $��14(�6�   ���#323636$
��Left=�6�   ���#6accbd$��19.8,240,0,0q�6�   $	��Top=�6	  $	��368��6!  $��31��6-  $��2��69  $��3��6M  ��6   �� *LoginCommand+6M  5,      53      54      