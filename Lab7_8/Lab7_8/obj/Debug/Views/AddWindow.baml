   M S B A M L   `   `   `  ����A  =Lab7_8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab7_8Lab7_8  5   	       Lab7_8.AddWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Lab7_8     5   	     � Title$  Todolik��5   	   $��278.518��6   $��430.666��6*    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P    � Icon$� �D:\OneDrive\Study\Course_2\2\ООП\Решения\Lab7_8\Lab7_8\Assets\ovni_alien_invader_space_galaxia_univers_abducted_man_icon_141227.ico��6u   .��5	      � .+�5
   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��
Task name:��6   $
��Left=�6-   $��	10,10,0,0q�6H   $	��Top=�6[   $��80��6s   �� 5      -   5        $��titleTB��5      $
��Left=�6)   $��26��6D   $��	47,10,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��270��6�   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Task description:��6   $
��Left=�64   $��	10,10,0,0q�6O   $	��Top=�6b   $��97��6z    J� RenderTransformOrigin$ 0.425,2.679&�6�   �� 5      -   5        $��descTB��5      $
��Left=�6(   $��45��6C   $��	30,10,0,0q�6O   $
 Wrap=�6b   $	��Top=�6v   $	��270��6�   5      �� 5      $ 
Horizontal=�6   $��0,10,0,0q�62   $��28��6D   .+�5      �� $��	Priority:��6   $
��Left=�6,   $��10,0,0,0q�6G   $	��Top=�6Y   $��97��6q   �� 5      -   5        $��
priorityCB��5      $��30,0,0,0q�6-   $	��267��6?   .@�5      �� High6&   �� 5      Medium6(   �� 5      Low6%   5      5      �� 5      $ 
Horizontal=�6   $��0,10,0,0q�62   $��28��6D   .+�5      �� $��	Category:��6   $
��Left=�6,   $��10,0,0,0q�6G   $	��Top=�6Y   $��97��6q   �� 5      -   5        $��
categoryCB��5      $��30,0,0,0q�6-   $	��267��6?   .@�5      �� Study6'   �� 5      Work6&   �� 5       House6'   �� 5!      Family6(   5"      5#      �� 5$      $ 
Horizontal=�6   $��0,10,0,0q�62   $��28��6D   .+�5%      �� $��Periodicity:��6   $
��Left=�6/   $��10,0,0,0q�6J   $	��Top=�6\   $��97��6t   �� 5&      -   5        $��periodicityCB��5&      $��30,0,0,0q�60   $	��267��6B   .@�5'      �� Single6(   �� 5(      Weekly6(   �� 5)      	Monthly6)   �� 5*      Yearly6(   5+      5,      �� 5-      $��0,10,0,0q�6   .+�5.      �� -   5        $��SaveBtn��5.      $
��Save��6H   $��	96,0,96,0q�6W   ��6)   �� *
AddNewTask+6W   5/      50      51      52      