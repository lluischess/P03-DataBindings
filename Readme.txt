Realizar la siguiente aplicación con tecnología ado.net databinding

Se trata de hacer la gestión de la tabla Members de la base de datos COMPASSTRAVEL de SqlServer.

Se piden las siguientes funcionalidades:

    Crear nuevos Members.
    Eliminar Members existentes.
    Modificar Members existentes.
    Poder de alguna manera indicar un número de Member, MemberID, y que el formulario se sitúe directamente en dicho Member.

 Restricciones varias:

    Situar todos los campos de la tabla en un formulario de forma ordenada y clara.
    El campo Password debe aparecer en pantalla con su contenido de manera 'encriptada' ***.
    También el Password debe tener una longitud mínima de 4 dígitos, si no es así mostrar un mensaje de error y obligar a cambiar el Password, por otro lado, si la longitud tiene entre 4 y 8 dígitos de longitud se mostrará un mensaje de advertencia indicando que se aconseja una longitud mínima de 9 digitos pero el password introducido es válido.
    Cuando el valor del USERNAME varíe comprobar que no existe otro Member con el mismo USERNAME si es así mostrar un mensaje de error y no permitir el valor anteriormente introducido.
    Por el USERNAME debe aparecer un botón que aconseje como USERNAME los tres primer caracteres del FirstName más las 3 últimas del Lastname, en el caso de que el usuario diga que sí se pondrá en el campo el valor que se ha calculado previamente.
    Cuando se esté modificando el valor de un registro no permitir modificar el valor de su MemberId.
    Deben existir tres botones (añadir, eliminar y editar).
    Si se activa el botón de eliminar siempre se pedirá conformidad.
    Si se activa el botón de añadir o editar desaparecerán los 3 botones antes mencionados y aparecerán 2 para aceptar o cancelar, si se cancela se deshará la edición o la inserción del nuevo registro.
    Cada vez que se acepte un inserción, modificación o eliminación se hará una persistencia en la base de datos automáticamente.
    Para movernos entre los registro o podremos hacer a través de un navegador, que únicamente estará activo si no se está insertando o editando.

TODAS LAS VALIDACIONES A NIVEL DE COLUMNA / FILA HACER MEDIANTE LOS EVENTOS DEL DataTable Y NO HACERLO MEDIANTE INTERFAZ DE COMUNICACIÓN CON EL USUARIO.
