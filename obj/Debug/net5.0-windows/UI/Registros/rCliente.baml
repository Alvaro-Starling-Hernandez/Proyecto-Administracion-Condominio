   M S B A M L   `   `   `  ����M  IProyectoCondominio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ProyectoCondominio.UI.RegistrosProyectoCondominio.UI.Registros  5   	   .    (ProyectoCondominio.UI.Registros.rCliente   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ProyectoCondominio.UI.Registros     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	     MaterialDesignPaper#���  5
   	   $��Regular"�5   	   $��14(�5   	     � Title$  	Mis Datos��5   	   $	��475��6   $	��525��6(    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ CanMinimize=�6Y   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10,0,0,0q�6,   .+�5      �� $ Vertical=�6   $
��0,10q�60   .+�5      �� $��0,5,10,0q�6   $
��Left=�6/   .+�5      �� $��Nombre Completo:��6   �� 5      -   5         ��Name$ NombreCompletoTextBox��5      ${�False��6U   $	��470��6g   $��5,0,0,0q�6s   ��6=   �� *Nombre+6s   5      �� 5      $��0,5,10,0q�6   $
��Left=�6/   .+�5      �� $��Nombre De Usuario:��6   �� 5      -   5        $ NombreUsuarioTextBox��5      ${�False��6[   $	��470��6m   $��5,0,0,0q�6y   ��6<   �� *NombreUsuario+6y   5      �� 5      $��0,5,10,0q�6   $
��Left=�6/   .+�5      �� $��Tipo De Documento:��6   �� 5      -   5        $ TipoDeDocumentoTextBox��5      ${�False��6]   $	��470��6o   $��5,0,0,0q�6{   ��6>   �� *TipoDocumento+6{   5       �� 5"      $��0,5,10,0q�6   $
��Left=�6/   .+�5#      �� $��
Documento:��6   �� 5$      -   5        $ DocumentoTextBox��5$      ${�False��6S   $	��470��6e   $��5,0,0,0q�6q   ��68   �� *	Documento+6q   5%      �� 5'      $��0,5,10,0q�6   $
��Left=�6/   .+�5(      �� $��No. Telefono/Celular:��6   �� 5)      -   5        $ TelefonoTextBox��5)      ${�False��6Q   $	��470��6c   $��5,0,0,0q�6o   ��67   �� *
Telefono+6o   5*      �� 5,      $��0,5,10,0q�6   $
��Left=�6/   .+�5-      �� $��Correo Electronico:��6   �� 5.      -   5        $ CorreoTextBox��5.      ${�False��6M   $	��470��6_   $��5,0,0,0q�6k   ��65   �� *Correo+6k   5/      50      �� 53      $ 
Horizontal=�6   $
��5,35q�62   $
��Left=�6@   .+�54      �� -   5         ��Name$ ModificarButton��54      .��55      �� $ 
Horizontal=�6!   .+�56      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ EditOutline=�62   $��25��6E   $��25��6P   �� 57      $��	Modificar��6    $
��Bold"�64   
�������6F   58      59      �� 5;      -   5        $ GuardarButton��5;      $
��20,0q�60   ${�False��6Z   .��5<      �� $ 
Horizontal=�6!   .+�5=        $ ContentSave=�62   $��25��6F   $��25��6Q   �� 5>      $��Guardar��6    $
��Bold"�62   
�������6D   5?      5@      �� 5B      -	   5        $ CambiarContraButton��5B      .��5C      �� $ 
Horizontal=�6!   .+�5D        $ PasswordReset=�62   $��25��6G   $��25��6R   �� 5E      $��Cambiar Contraseña��6    $
��Bold"�6=   
�������6O   5F      5G      5H      5I      5J      5K      