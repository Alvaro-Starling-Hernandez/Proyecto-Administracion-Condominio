   M S B A M L   `   `   `  ����M  IProyectoCondominio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ProyectoCondominio.UI.RegistrosProyectoCondominio.UI.Registros  5   	   /    )ProyectoCondominio.UI.Registros.rInmueble   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ProyectoCondominio.UI.Registros     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	     MaterialDesignPaper#���  5
   	   $��Regular"�5   	   $��14(�5   	     � Title$  Registro de Inmueble��5   	   $	��460��6&   $	��420��63    � WindowStartupLocation$ CenterScreen=�6?    � 
ResizeMode$ CanMinimize=�6d   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10,0,0,0q�6,   .+�5      �� $ Vertical=�6   $
��0,10q�60   .+�5      �� $��Inmueble Id:��6   �� 5      $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ IdInmuebleTextBox��5      $	��100��6U   $��23��6a   $��5,0,0,0q�6m   ��69   �� *
IdInmueble+6~   �� 5      -   5         ��Name$ BuscarButton��5      $
��25,0q�64   .��5      �� $ 
Horizontal=�6%   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�66   $��25��6D   $��25��6O   �� 5      $��Buscar��6$   $
��Bold"�65   
�������6G   5      5      5      �� 5      $��0,5,10,0q�6   $
��Left=�6/   .+�5      �� $��Codigo:��6   �� 5       -   5        $ CodigoTextBox��5       $	��350��6M   $��5,0,0,0q�6Y   ��65   �� *Codigo+6Y   5!      �� 5#      $��0,5,10,0q�6   $
��Left=�6/   .+�5$      �� $��Tipo De Inmueble:��6   �� 5%      -   5         ��Name$ TipoInmuebleCombobox��5%      $	��350��6f   $��5,0,0,0q�6r    �� SelectedValue 6=   �� *IdTipoInmueble+6r   5&      �� 5(      $��0,5,10,0q�6   $
��Left=�6/   .+�5)      �� $��Descripcion:��6   �� 5*      -   5        $ DescripcionTextBox��5*      $	��350��6W   $��5,0,0,0q�6c   ��6:   �� *Descripcion+6c   5+      �� 5-      $��0,5,10,0q�6   $
��Left=�6/   .+�5.      �� $��
Direccion:��6   �� 5/      -   5        $ DirecionTextBox��5/      $	��350��6R   $��5,0,0,0q�6^   ��67   �� *	Direccion+6^   50      �� 52      $��0,5,10,0q�6   $
��Left=�6/   .+�53      �� $��Precio de Alquiler:��6   �� 54      -   5        $ PrecioAlquilerTextBox��54      $	��350��6n   $��5,0,0,0q�6z   ��6=   �� *PrecioAlquiler+	 �� StringFormat$	 N2��6�   55      56      �� 59      $ 
Horizontal=�6   $
��5,15q�62   $
��Left=�6@   .+�5:      �� -   5        $ NuevoButton��5:      .��5;      �� $ 
Horizontal=�6!   .+�5<        $ NewspaperPlus=�62   $��25��6G   $��25��6R   �� 5=      $��Nuevo��6    $
��Bold"�60   
�������6B   5>      5?      �� 5A      -	   5        $ GuardarButton��5A      $
��20,0q�60   .��5B      �� $ 
Horizontal=�6!   .+�5C        $ ContentSave=�62   $��25��6F   $��25��6Q   �� 5D      $��Guardar��6    $
��Bold"�62   
�������6D   5E      5F      �� 5H      -
   5        $ EliminarButton��5H      .��5I      �� $ 
Horizontal=�6!   .+�5J        $ DeleteForever=�62   $��25��6G   $��25��6R   �� 5K      $��Eliminar��6    $
��Bold"�63   
�������6E   5L      5M      5N      5O      5P      5Q      