   M S B A M L   `   `   `  ����M  IProyectoCondominio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:ProyectoCondominio.UI.RecibosProyectoCondominio.UI.Recibos  5   	   6    0ProyectoCondominio.UI.Recibos.ContratoDeAlquiler   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:ProyectoCondominio.UI.Recibos     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	     MaterialDesignPaper#���  5
   	   $��Regular"�5   	   $��16(�5   	     � Title$  Detalle De Contrato��5   	   $
��1200��6%   $��793.92��63    � WindowStyle$
 None=�6B    � 
ResizeMode$ NoResize=�6U   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � -   5         �Name$ print2��5      .+�5   
   �� $��30q�6   .+�5      ��  �� Orientation$ Vertical=�6   $��0,0,0,10q�60   .+�5      �� $��Detalle de Contrato��6   $��Center=�66   $
��Bold"�6S   $��30(�6e   $��0,0,0,20q�6s   �� 5      $ 
Horizontal=�6   .+�5      �� $ 
Horizontal=�6!   .+�5      �� $��Fecha Registro:��6    $��Medium"�6:   �� 5      -   5         ��Name$ FechaRegistroLabel��5       $��Fecha��6<   $��35,0,0,0q�6L   5      �� 5      $ 
Horizontal=�6!   $��	300,0,0,0q�6:   .+�5      �� $��Codigo Alquiler:��6    $��Medium"�6;   �� 5      -   5        $ CodigoLabel��5       $��Codigo��65   $��20,0,0,0q�6F   5      5      5      �� 5!      	 �� X1$ 0��6   	 �� X2$ 763.92��6   	 �� Y1$ 1��6&   		 �� Y2$	 1��6-   
���   �$��2��6C   �� 5#      $
��0,10q�6   $ Vertical=�6'   .+�5$      �� $��Datos del Propietario:��6   $
��Bold"�69   $��20(�6K   $��0,0,0,10q�6Y   �� 5%      $ 
Horizontal=�6   .+�5&      �� $��Nombre Completo:��6   $��Medium"�67   �� 5'      -   5        $ NombreCompletoLabel��5'      $��Nombre��69   $��40,0,0,0q�6J   5(      �� 5*      $ 
Horizontal=�6   .+�5+      �� $��Tipo de documento:��6   $��Medium"�69   �� 5,      -   5        $ TipoDocuemntoLabel��5,      $��TipoDocuemnto��68   $��33,0,0,0q�6P   5-      �� 5/      $ 
Horizontal=�6   .+�50      �� $��No. Documento:��6   $��Medium"�65   �� 51      -   5        $ DocuemntoLabel��51      $��	Documento��64   $��58,0,0,0q�6H   52      �� 54      $ 
Horizontal=�6   .+�55      �� $��Correo Electronico:��6   $��Medium"�6:   �� 56      -   5        $ CorreoLabel��56      $��Correo��61   $��40,0,0,0q�6B   57      �� 59      $ 
Horizontal=�6   .+�5:      �� $��	Telefono:��6   $��Medium"�60   �� 5;      -   5        $ TelefonoLabel��5;      $��Telefono��63   $��	110,0,0,0q�6F   5<      5?      �� 5B      $ 0��6   $ 763.92��6   $ 1��6&   $	 1��6-   
���   �$��2��6C   �� 5D      $
��0,20q�6   $ Vertical=�6'   .+�5E      �� $��Datos del Inquilino:��6   $
��Bold"�67   $��20(�6I   $��0,0,0,10q�6W   �� 5G      $ 
Horizontal=�6   .+�5H      �� $��Nombre Completo:��6   $��Medium"�67   �� 5I      -	   5        $" NombreCompletoInquilinoLabel��5I      $��Nombre��6B   $��40,0,0,0q�6S   5J      �� 5L      $ 
Horizontal=�6   .+�5M      �� $��Tipo de documento:��6   $��Medium"�69   �� 5N      -
   5        $! TipoDocuemntoInquilinoLabel��5N      $��TipoDocuemnto��6A   $��33,0,0,0q�6Y   5O      �� 5Q      $ 
Horizontal=�6   .+�5R      �� $��No. Documento:��6   $��Medium"�65   �� 5S      -   5        $ DocuemntoInquilinoLabel��5S      $��	Documento��6=   $��59,0,0,0q�6Q   5T      �� 5V      $ 
Horizontal=�6   .+�5W      �� $��Correo Electronico:��6   $��Medium"�6:   �� 5X      -   5        $ CorreoInquilinoLabel��5X      $��Correo��6:   $��40,0,0,0q�6K   5Y      �� 5[      $ 
Horizontal=�6   .+�5\      �� $��	Telefono:��6   $��Medium"�60   �� 5]      -   5        $ TelefonoInquilinoLabel��5]      $��Telefono��6<   $��	110,0,0,0q�6O   5^      5`      �� 5c      $ 0��6   $ 763.92��6   $ 1��6&   $	 1��6-   
���   �$��2��6C   �� 5e      $
��0,20q�6   $ Vertical=�6'   .+�5f      �� $��Datos del Inmueble:��6   $
��Bold"�66   $��20(�6H   $��0,0,0,10q�6V   �� 5g      $ 
Horizontal=�6   .+�5h      �� $��Codigo Inmueble:��6   $��Medium"�67   �� 5i      -   5        $ CodigoImuebleLabel��5i      $��Codigo��68   $��46,0,0,0q�6I   5j      �� 5l      $ 
Horizontal=�6   .+�5m      �� $��Descripcion:��6   $��Medium"�63   �� 5n      -   5        $ DescripcionLabel��5n      $��Descripcion��66   $��80,0,0,0q�6L   5o      �� 5q      $ 
Horizontal=�6   .+�5r      �� $��Tipo Inmueble:��6   $��Medium"�65   �� 5s      -   5        $ TipoInmuebleLael��5s      $
��Tipo��66   $��63,0,0,0q�6E   5t      5w      �� 5{      $ 0��6   $ 763.92��6   $ 1��6&   $	 1��6-   
���   �$��2��6C   �� 5}      $
��0,20q�6   $ Vertical=�6'   .+�5~      �� $��Resumen Alquiler:��6   $
��Bold"�64   $��20(�6F   $��0,0,0,10q�6T   �� 5�      $ 
Horizontal=�6   .+�5�      �� $��Fecha Inicio Alquiler:��6   $��Medium"�6=   �� 5�      -   5        $ FechaInicioLabel��5�      $	��111��66   $��20,0,0,0q�6D   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $��Tipo Alquiler:��6   $��Medium"�65   �� 5�      -   5        $ TipoAlquilerLabel��5�      $	��111��67   $��75,0,0,0q�6E   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $��Cant. de Periodos:��6   $��Medium"�69   �� 5�      -   5        $ CantidadPeriodoslabel��5�      $	��111��6;   $��39,0,0,0q�6I   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $��Tipo Moneda:��6   $��Medium"�63   �� 5�      -   5        $ TipoMonedaLabel��5�      $	��111��65   $��72,0,0,0q�6C   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $��Precio Alquiler:��6   $��Medium"�67   �� 5�      -   5        $ PrecioLabel��5�      $	��111��61   $��62,0,0,0q�6?   5�      5�      �� 5�      $��
10,60,0,10q�6   $ 
Horizontal=�6-   .+�5�      �� $ Vertical=�6   .+�5�      �� $ 0��6   $	 250��6"   $ 1��6+   $	 1��62   
���   �$��1��6H   �� 5�      $��Firma del Inquilino��6   $��50,0,0,0q�6:   5�      �� 5�      $ Vertical=�6   $��	215,0,0,0q�65   .+�5�      �� $ 0��6   $	 250��6"   $ 1��6+   $	 1��62   
���   �$��1��6H   �� 5�      $��Firma del Propietario��6   $��50,0,0,0q�6<   5�      5�      5�      5�      5�      