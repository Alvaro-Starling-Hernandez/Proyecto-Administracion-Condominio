   M S B A M L   `   `   `  ����M  IProyectoCondominio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ProyectoCondominio.UI.RegistrosProyectoCondominio.UI.Registros  5   	   3    -ProyectoCondominio.UI.Registros.rTipoAlquiler   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ProyectoCondominio.UI.Registros     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	     MaterialDesignPaper#���  5
   	   $��Regular"�5   	   $��14(�5   	     � Title$"  Registro de Tipo de Alquiler��5   	   $	��301��6.   $	��420��6;    � WindowStartupLocation$ CenterScreen=�6G    � 
ResizeMode$ CanMinimize=�6l   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10,0,0,0q�6,   .+�5      �� $ Vertical=�6   $
��0,10q�60   .+�5      �� $��Tipo de Alquiler Id:��6   �� 5      $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ TipoAlquilerIdTextBox��5      $	��100��6]   $��23��6i   $��5,0,0,0q�6u   ��6=   �� *IdTipoAlquiler+6�   �� 5      -   5         ��Name$ BuscarButton��5      $
��25,0q�64   .��5      �� $ 
Horizontal=�6%   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�66   $��25��6D   $��25��6O   �� 5      $��Buscar��6$   $
��Bold"�65   
�������6G   5      5      5      �� 5      $��0,5,10,0q�6   $
��Left=�6/   .+�5      �� $��Descripcion:��6   �� 5       -   5        $ DescripcionTextBox��5       $	��350��6W   $��5,0,0,0q�6c   ��6:   �� *Descripcion+6c   5!      �� 5#      $��0,5,10,0q�6   $
��Left=�6/   .+�5$      �� $��Cantidad dias:��6   �� 5%      -   5        $ DiasTextBox��5%      $	��100��6I   $��5,0,0,0q�6U   ��63   �� *Dias+6f   5&      5(      �� 5+      $ 
Horizontal=�6   $
��5,15q�62   $
��Left=�6@   .+�5,      �� -   5        $ NuevoButton��5,      .��5-      �� $ 
Horizontal=�6!   .+�5.        $ NewspaperPlus=�62   $��25��6G   $��25��6R   �� 5/      $��Nuevo��6    $
��Bold"�60   
�������6B   50      51      �� 53      -   5        $ GuardarButton��53      $
��20,0q�60   .��54      �� $ 
Horizontal=�6!   .+�55        $ ContentSave=�62   $��25��6F   $��25��6Q   �� 56      $��Guardar��6    $
��Bold"�62   
�������6D   57      58      �� 5:      -   5        $ EliminarButton��5:      .��5;      �� $ 
Horizontal=�6!   .+�5<        $ DeleteForever=�62   $��25��6G   $��25��6R   �� 5=      $��Eliminar��6    $
��Bold"�63   
�������6E   5>      5?      5@      5A      5B      5C      