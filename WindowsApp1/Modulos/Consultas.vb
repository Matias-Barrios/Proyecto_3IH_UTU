Imports System.Globalization

Module Consultas

    Public uno As New Integer
    Public dos As New Integer
    Public tres As New Integer

    Public Function CONSULTAS_SELECT_ALUMNOS() As String
        Return "SELECT CI,tmp.nombre_grupo as Grupo,(Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido ) AS nombre_completo,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,fecha_nacimiento,email,hace_proyecto,nota_final_pro,juicio_final
                FROM Personas 
                left JOIN (select distinct foranea_ci_alumno, grupos.nombre_grupo 
							from relacion_alumno_asignatura_grupos
							join Grupos on id_grupo = foranea_id_grupo
							order by foranea_ci_alumno) as tmp
				on tmp.foranea_ci_alumno = Personas.CI
                WHERE tipo = 'Alumno' AND baja = 'f';"
    End Function

    Public Function CONSULTAS_SELECT_INSTITUTOS() As String
        Return "SELECT id_instituto,nombre,calle,numero,telefonos,email,Ciudad.nombre_ciudad 
                FROM Institutos,Ciudad 
                WHERE Institutos.baja = 'f' and Institutos.foranea_id_ciudad = Ciudad.id_ciudad"
    End Function
    Public Function CONSULTAS_SELECT_INSTITUTOS_PARA_LISTBOX() As String
        Return "SELECT id_instituto,nombre  
                FROM Institutos 
                WHERE Institutos.baja = 'f'"
    End Function

    Public Function CONSULTAS_SELECT_INSTITUTOS_CALIFICACIONES_COMBOBOX() As String

        Return "select id_instituto, nombre
        from Institutos, relacion_docente_trabaja_instituto
        where id_instituto = foranea_id_instituto
        and Institutos.baja = 'f'
        and foranea_ci_docente = " & USUARIO_LOGUEADO.CI

    End Function


    Public Function CONSULTAS_SELECT_ORIENTACIONES_PARA_LISTBOX() As String
        Return "Select id_orientacion,nombre_orientacion  
                FROM Orientaciones 
                WHERE Orientaciones.baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_ASIGNATURAS() As String
        Return "SELECT id_asignatura,nombre_asignatura,descripcion 
                FROM Asignaturas 
                WHERE baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_CIUDADES() As String
        Return "SELECT id_ciudad,nombre_ciudad,nombre_departamento   
                FROM Ciudad 
                WHERE baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_ORIENTACIONES() As String
        Return "SELECT id_orientacion,nombre_orientacion,descripcion 
                FROM Orientaciones 
                WHERE baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_DOCENTES() As String
        Return "SELECT CI,(Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido ) AS nombre_completo,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,fecha_nacimiento,email,grado
                FROM Personas 
                WHERE tipo = 'Docente' AND baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_GRUPOS() As String
        Return "SELECT Grupos.id_grupo,Grupos.nombre_grupo,Grupos.turno,Institutos.nombre,Orientaciones.nombre_orientacion
                from Grupos
                left join Institutos on Institutos.id_instituto = Grupos.foranea_id_instituto 
                left join Orientaciones on Orientaciones.id_orientacion = Grupos.foranea_id_orientacion 
                where Grupos.baja = 'f';"
    End Function
    Public Function CONSULTAS_SELECT_AdministrativoES() As String
        Return "SELECT CI,(Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido ) AS nombre_completo,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,fecha_nacimiento,email
                FROM Personas 
                WHERE tipo = 'Administrativo' AND baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_ADMINS() As String
        Return "SELECT CI,(Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido ) AS nombre_completo,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,fecha_nacimiento,fecha_nacimiento,email
                FROM Personas 
                WHERE tipo = 'Admin' AND baja = 'f'"
    End Function



    Public Function CONSULTAS_SELECT_CALIFICACIONES() As String
        Return "SELECT id_calificacion,
		                (select Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido from Personas where Personas.CI = CI_docente) AS nombre_docente,
		                CI_docente,
		                (select Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido  from Personas where Personas.CI = CI_alumno) AS nombre_alumno,
		                CI_alumno,
		                Asignaturas.nombre_asignatura, 
		                Grupos.nombre_grupo,
		                Institutos.nombre,
		                nombre_calificacion,
		                categoria,
		                TO_CHAR(fecha, '%A %B %d, %Y %R'),
		                comentario,
		                nota
                FROM Calificaciones
                join Asignaturas on Asignaturas.id_asignatura = Calificaciones.id_asignatura
                join Grupos on Grupos.id_grupo = Calificaciones.id_grupo
                join Institutos on Institutos.id_instituto = Calificaciones.id_instituto
                WHERE Calificaciones.baja = 'f' 
                order by fecha DESC"
    End Function

    Public Function CONSULTAS_SELECT_USUARIOS() As String
        Return "SELECT CI,(Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido ) AS nombre_completo,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,fecha_nacimiento,email 
                FROM Personas
                WHERE baja = 'f' AND encriptacion_hash is not null AND baja = 'f'"
    End Function

    Public Function CONSULTAS_SELECT_POTENCIALES_USUARIOS() As String
        Return "SELECT CI,(Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido ) AS nombre_completo,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,fecha_nacimiento,email
                FROM Personas 
                WHERE baja = 'f' AND tipo IN ('Admin','Docente','Administrativo')"
    End Function

    Public Function CREAR_USUARIO(CI As Integer, hash As String, sal As String) As String
        Dim query As String = "UPDATE Personas SET encriptacion_hash = '" & hash & "',encriptacion_sal = '" & sal & "'  WHERE CI = " & CI
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function BAJA_LOGICA_USUARIO(CI As Integer) As String
        Dim query As String = "UPDATE Personas SET encriptacion_hash = null,encriptacion_sal = null  WHERE CI = " & CI
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function BAJA_LOGICA_ALUMNO(CI As Integer) As String
        Dim query As String = "UPDATE Personas SET baja = 't'  WHERE CI = " & CI
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function BAJA_LOGICA_GRUPO(id_grupo As Integer) As String
        Dim query As String = "UPDATE Grupos SET baja = 't'  WHERE id_grupo = " & id_grupo
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function BAJA_LOGICA_ASIGNATURA(id_asignatura As Integer) As String
        Dim query As String = "UPDATE Asignaturas SET baja = 't'  WHERE id_asignatura = " & id_asignatura
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function BAJA_LOGICA_CALIFICACION(id_calificacion As Integer) As String
        Dim query As String = "UPDATE Calificaciones SET baja = 't'  WHERE id_calificacion = " & id_calificacion
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function BAJA_LOGICA_DOCENTE(CI As Integer) As String
        Dim query As String = "UPDATE Personas SET baja = 't'  WHERE CI = " & CI
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function BAJA_LOGICA_INSTITUTO(id_instituto As Integer) As String
        Dim query As String = "UPDATE Institutos SET baja = 't'  WHERE id_instituto = " & id_instituto
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function BAJA_LOGICA_ORIENTACION(id_orientacion As Integer) As String
        Dim query As String = "UPDATE Orientaciones SET baja = 't'  WHERE id_orientacion = " & id_orientacion
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function BAJA_LOGICA_CIUDAD(id_ciudad As Integer) As String
        Dim query As String = "UPDATE Ciudad SET baja = 't'  WHERE id_ciudad = " & id_ciudad
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function CREAR_ALUMNO(CI As String, primer_nombre As String, segundo_nombre As String, primer_apellido As String, segundo_apellido As String, fecha_nacimiento As Date, email As String, hace_proyecto As Boolean, convertir_fecha_ingles As Boolean) As String
        Dim fecha_con_formato As String
        Dim hace_proyecto_como_letra As String = "t"
        If convertir_fecha_ingles Then
            fecha_con_formato = fecha_nacimiento.ToString("dd/MM/yyyy")
        Else
            fecha_con_formato = fecha_nacimiento.ToString("MM/dd/yyyy")
        End If
        If hace_proyecto = False Then
            hace_proyecto_como_letra = "f"
        End If
        Dim consulta As String = "INSERT INTO Personas (CI, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, fecha_nacimiento, email, grado, hace_proyecto, nota_final_pro, juicio_final, tipo, encriptacion_hash, encriptacion_sal, baja)
                VALUES(" & CI & ",'" & primer_nombre & "','" & segundo_nombre & "','" & primer_apellido & "','" & segundo_apellido & "'," & fecha_con_formato & ",'" & email & "'," & "NULL" & ",'" & hace_proyecto_como_letra & "'," & 1 & "," & "'Examen Febrero'" & "," & "'Alumno'" & "," & "NULL" & "," & "NULL" & "," & "'f'" & ")"
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function

    Public Function MODIFICAR_ADMIN_ADMINISTRATIVO(CI_original As Integer, un_admin As DataGridViewRow, convertir_fecha_ingles As Boolean) As String
        Dim fecha_con_formato As String
        Dim hace_proyecto_como_letra As String = "t"
        If convertir_fecha_ingles Then
            fecha_con_formato = un_admin.Cells("fecha_nacimiento").Value().ToString().Split(" ")(0)
        Else
            fecha_con_formato = un_admin.Cells("fecha_nacimiento").Value().ToString().Split(" ")(0)
        End If

        Dim consulta As String = "UPDATE Personas SET " &
                " CI = " & un_admin.Cells("CI").Value() & "," &
                " primer_nombre = '" & un_admin.Cells("primer_nombre").Value() & "'," &
                " segundo_nombre = '" & un_admin.Cells("segundo_nombre").Value() & "'," &
                " primer_apellido = '" & un_admin.Cells("primer_apellido").Value() & "'," &
                " segundo_apellido = '" & un_admin.Cells("primer_apellido").Value() & "'," &
                " fecha_nacimiento = " & fecha_con_formato & "," &
                " email = '" & un_admin.Cells("email").Value() & "'," &
                " hace_proyecto = 'f'," &
                " nota_final_pro = '1'" &
                " WHERE CI = " & CI_original
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function

    Public Function MODIFICAR_ALUMNO(CI_original As Integer, alumno As DataGridViewRow, convertir_fecha_ingles As Boolean) As String
        Dim fecha_con_formato As String
        Dim hace_proyecto_como_letra As String = "t"
        If convertir_fecha_ingles Then
            fecha_con_formato = alumno.Cells("fecha_nacimiento").Value().ToString().Split(" ")(0)
        Else
            fecha_con_formato = alumno.Cells("fecha_nacimiento").Value().ToString().Split(" ")(0)
        End If
        If alumno.Cells("hace_proyecto").Value() = False Then
            hace_proyecto_como_letra = "f"
        End If
        Dim consulta As String = "UPDATE Personas SET " &
                " CI = " & alumno.Cells("CI").Value() & "," &
                " primer_nombre = '" & alumno.Cells("primer_nombre").Value() & "'," &
                " segundo_nombre = '" & alumno.Cells("segundo_nombre").Value() & "'," &
                " primer_apellido = '" & alumno.Cells("primer_apellido").Value() & "'," &
                " segundo_apellido = '" & alumno.Cells("primer_apellido").Value() & "'," &
                " fecha_nacimiento = " & fecha_con_formato & "," &
                " email = '" & alumno.Cells("email").Value() & "'," &
                " hace_proyecto = '" & hace_proyecto_como_letra & "'," &
                " nota_final_pro = '" & alumno.Cells("nota_final_pro").Value() & "'" &
                " WHERE CI = " & CI_original
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function

    Public Function MODIFICAR_ORIENTACION(ori_original As Integer, nombre As String, descripcion As String) As String

        Dim consulta As String = "UPDATE Orientaciones SET " &
                " nombre_orientacion  = '" & nombre & "'," &
                " descripcion   = '" & descripcion & "'" &
                " WHERE id_orientacion = " & ori_original.ToString()
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function

    Public Function MODIFICAR_DOCENTE(CI_original As Integer, docente As DataGridViewRow, convertir_fecha_ingles As Boolean) As String
        Dim fecha_con_formato As String
        Dim hace_proyecto_como_letra As String = "t"
        If convertir_fecha_ingles Then
            fecha_con_formato = docente.Cells("fecha_nacimiento").Value().ToString().Split(" ")(0)
        Else
            fecha_con_formato = docente.Cells("fecha_nacimiento").Value().ToString().Split(" ")(0)
        End If
        Dim consulta As String = "UPDATE Personas SET " &
                " CI = " & docente.Cells("CI").Value() & "," &
                " primer_nombre = '" & docente.Cells("primer_nombre").Value() & "'," &
                " segundo_nombre = '" & docente.Cells("segundo_nombre").Value() & "'," &
                " primer_apellido = '" & docente.Cells("primer_apellido").Value() & "'," &
                " segundo_apellido = '" & docente.Cells("primer_apellido").Value() & "'," &
                " fecha_nacimiento = " & fecha_con_formato & "," &
                " email = '" & docente.Cells("email").Value() & "'," &
                " grado = " & docente.Cells("grado").Value().ToString() &
                " WHERE CI = " & CI_original
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function
    Public Function MODIFICAR_GRUPO(id_grupo_original As Integer, Grupo As DataGridViewRow, id_instituto As Integer, id_orientacion As Integer) As String
        Dim consulta As String = "UPDATE Grupos SET " &
                " turno = '" & Grupo.Cells("turno").Value() & "'," &
                " foranea_id_instituto  = " & id_instituto & "," &
                " foranea_id_orientacion  = " & id_orientacion &
                " WHERE id_grupo = " & id_grupo_original
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function
    Public Function MODIFICAR_CIUDAD(ciudad As DataGridViewRow, departamento As String) As String
        Dim consulta As String = "UPDATE Ciudad SET " &
                " nombre_ciudad = '" & ciudad.Cells("nombre_ciudad").Value() & "'," &
                " nombre_departamento   = '" & departamento & "'" &
                " WHERE id_ciudad  = " & ciudad.Cells("id_ciudad").Value().ToString()
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function



    Public Function CREAR_DOCENTE(CI As String, primer_nombre As String, segundo_nombre As String, primer_apellido As String, segundo_apellido As String, fecha_nacimiento As Date, email As String, grado As Integer, convertir_fecha_ingles As Boolean) As String
        Dim fecha_con_formato As String
        If convertir_fecha_ingles Then
            fecha_con_formato = fecha_nacimiento.ToString("dd/MM/yyyy")
        Else
            fecha_con_formato = fecha_nacimiento.ToString("MM/dd/yyyy")
        End If
        Dim consulta As String = "INSERT INTO Personas (CI, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, fecha_nacimiento, email, grado, hace_proyecto, nota_final_pro, juicio_final, tipo, encriptacion_hash, encriptacion_sal, baja)
                VALUES(" & CI & ",'" & primer_nombre & "','" & segundo_nombre & "','" & primer_apellido & "','" & segundo_apellido & "'," & fecha_con_formato & ",'" & email & "'," & grado & ",'" & "f" & "'," & "NULL" & "," & "Examen Febrero" & "," & "'Docente'" & "," & "NULL" & "," & "NULL" & "," & "'f'" & ")"
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function
    Public Function CREAR_GRUPO(nombre As String, turno As String, id_instituto As Integer, id_orientacion As Integer) As String


        Dim consulta As String = "INSERT INTO Grupos (foranea_id_instituto, nombre_grupo, turno, baja, foranea_id_orientacion)
                VALUES(" & id_instituto & ",'" & nombre & "','" & turno & "','" & "f" & "'," & id_orientacion & ")"
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))

        Return consulta
    End Function
    Public Function CREAR_ASIGNATURA(nombre As String, descripcion As String) As String


        Dim consulta As String = "INSERT INTO Asignaturas (nombre_asignatura  , descripcion, baja)
                VALUES('" & nombre & "','" & descripcion & "'," & "'f'" & ")"
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function
    Public Function MODIFICAR_ASIGNATURA(asignatura As DataGridViewRow) As String

        Dim consulta As String = "UPDATE Asignaturas SET " &
                " nombre_asignatura = '" & asignatura.Cells("nombre_asignatura").Value() & "'," &
                " descripcion = '" & asignatura.Cells("descripcion").Value() & "'" &
                " WHERE id_asignatura = " & asignatura.Cells("id_asignatura").Value()
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function

    Public Function COMBOBOX_CALIFICACIONES_GRUPO(grupo As ComboBox, cboInstituto As ComboBox) As String

        Dim prueba = grupo.SelectedIndex
        Dim prueba1 = cboInstituto.SelectedIndex

        Dim resultado
        Dim resultado2

        resultado = hacer_consulta(COMBOBOX_CALIFICACIONES_INSTITUTO(cboInstituto)).Rows(prueba).Item("id_grupo")
        resultado2 = hacer_consulta(CONSULTAS_SELECT_INSTITUTOS_CALIFICACIONES_COMBOBOX()).Rows(prueba1).Item("id_instituto")

        Return "select id_asignatura, nombre_asignatura
    from Asignaturas, relacion_docente_asignatura_grupos, institutos
    where id_asignatura = foranea_id_asignatura
    and foranea_ci_docente = " & USUARIO_LOGUEADO.CI & "
    and foranea_id_grupo = " & resultado & "
    and id_instituto = " & resultado2


    End Function

    Public Function COMBOBOX_CALIFICACIONES_INSTITUTO(cboInstituto As ComboBox) As String

        Dim prueba1 = cboInstituto.SelectedIndex

        Dim resultado2

        resultado2 = hacer_consulta(CONSULTAS_SELECT_INSTITUTOS_CALIFICACIONES_COMBOBOX()).Rows(prueba1).Item("id_instituto")

        Return "select id_grupo, nombre_grupo
        from Grupos A, relacion_docente_asignatura_grupos B
        where id_grupo = foranea_id_grupo
        and foranea_ci_docente = " & USUARIO_LOGUEADO.CI &
        "and B.foranea_id_instituto =" & resultado2 & "and foranea_ci_docente = " & USUARIO_LOGUEADO.CI & "
        and B.foranea_id_instituto =" & resultado2
    End Function

    Public Function COMBOBOX_CALIFICACIONES_COMPLETA(cboAsignatura As ComboBox, cboInstituto As ComboBox, cboGrupo As ComboBox) As String
        If USUARIO_LOGUEADO.tipo = "Docente" Then

            Dim prueba1 = cboInstituto.SelectedIndex
            Dim prueba2 = cboGrupo.SelectedIndex
            Dim prueba = cboAsignatura.SelectedIndex


            uno = hacer_consulta(CONSULTAS_SELECT_INSTITUTOS_CALIFICACIONES_COMBOBOX()).Rows(prueba1).Item("id_instituto")
            dos = hacer_consulta(COMBOBOX_CALIFICACIONES_INSTITUTO(cboInstituto)).Rows(prueba2).Item("id_grupo")
            tres = hacer_consulta(COMBOBOX_CALIFICACIONES_GRUPO(cboGrupo, cboInstituto)).Rows(prueba).Item("id_asignatura")

            Return "select id_calificacion,
       CI_alumno,
       (select Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido  from Personas where Personas.CI = CI_alumno) AS nombre_alumno,
	   nombre_calificacion,
       nota,
       categoria,
       comentario,
       TO_CHAR(fecha, '%A %B %d, %Y %R') as Fecha
       From calificaciones a
       Where a.baja = 'f'
       And ci_docente = " & USUARIO_LOGUEADO.CI &
       " And a.id_grupo = " & dos & "
       And a.id_instituto = " & uno & "
       and a.id_asignatura = " & tres
        Else
            Return "select id_calificacion,
           CI_alumno,
           (select Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido  from Personas where Personas.CI = CI_alumno) AS nombre_alumno,
	       nombre_calificacion,
           nota,
           categoria,
           comentario,
           TO_CHAR(fecha, '%A %B %d, %Y %R') as Fecha
           From calificaciones a
           Where a.baja = 'f'"
        End If
    End Function

    Public Function CONSULTA_LOGIN(cedula As Integer) As String
        Return "Select * FROM Personas Where CI = " & cedula
    End Function

    Public Function CREAR_CALIFICACION(CI_docente As Integer, cedula_alumno As Integer, id_asignatura As Integer, id_grupo As Integer, id_instituto As Integer, nombre_calificacion As String, categoria As String, fecha As Date, comentario As String, nota As Integer, convertir_fecha_ingles As Boolean) As String
        'INSERT INTO Calificaciones (CI_docente, CI_alumno, id_asignatura, id_grupo, id_instituto, nombre_calificacion, categoria, fecha, comentario, nota, baja )
        'VALUES(54530570, 34596300, 58, 7, 1, "Un trabajillo", "Trabajo_laboratorio", "05/08/2018", "Esto es una descripcion", 2, "f");
        Dim fecha_con_formato As String
        If convertir_fecha_ingles Then
            fecha_con_formato = fecha.ToString().Split(" ")(0)
        Else
            fecha_con_formato = fecha.ToString().Split(" ")(0)
        End If

        Dim consulta As String = "INSERT INTO Calificaciones (CI_docente, CI_alumno, id_asignatura, id_grupo, id_instituto, nombre_calificacion, categoria, fecha, comentario, nota, baja ) VALUES(" &
            CI_docente & "," &
            cedula_alumno & "," &
            id_asignatura & "," &
            id_grupo & "," &
            id_instituto & ",'" &
            nombre_calificacion & "','" &
            categoria & "'," &
            fecha & ",'" &
            comentario & "'," &
            nota & "," & "'f' )"

        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta

    End Function


    Public Function CONSULTAS_INVITADOSALUMNOS(txtalumnoci As TextBox) As String

        Dim ci

        ci = Val(txtalumnoci.Text)

        Return "select nombre_asignatura,
       nota_final_asignatura,
       Nota_final_pro as Nota_Proyecto_Por_Asignatura,
       juicio_final
from relacion_alumno_asignatura_grupos, asignaturas , Personas
where foranea_ci_alumno =  ci
and ci =  " & ci & "
and id_asignatura = foranea_id_asignatura
and Personas.baja = 'f'"
    End Function


    Public Function CONSULTA_PROMEDIO_FINAL_ASIGNATURA(txtalumnoci As TextBox)

        Dim ci

        ci = Val(txtalumnoci.Text)

        Return "select round ( coalesce(avg(nota_final_asignatura),0))
        from relacion_alumno_asignatura_grupos
        where  foranea_CI_alumno =" & ci

    End Function

    Public Function CONSULTA_PROMEDIO_FINAL_PROYECTO(txtalumnoci As TextBox)

        Dim ci

        ci = Val(txtalumnoci.Text)

        Return "select round ( coalesce(avg(nota_final_asignatura),0))
        from relacion_alumno_asignatura_grupos
        where  foranea_CI_alumno =" & ci


    End Function

    Public Function CREAR_ADMIN(CI As String, primer_nombre As String, segundo_nombre As String, primer_apellido As String, segundo_apellido As String, fecha_nacimiento As Date, email As String, admin As Boolean, convertir_fecha_ingles As Boolean) As String
        Dim fecha_con_formato As String
        Dim tipo_persona = "Admin"
        If Not admin Then
            tipo_persona = "Administrativo"
        End If
        If convertir_fecha_ingles Then
            fecha_con_formato = fecha_nacimiento.ToString("dd/MM/yyyy")
        Else
            fecha_con_formato = fecha_nacimiento.ToString("MM/dd/yyyy")
        End If
        Dim consulta As String = "INSERT INTO Personas (CI, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, fecha_nacimiento, email, grado, hace_proyecto, nota_final_pro, juicio_final, tipo, encriptacion_hash, encriptacion_sal, baja)
                                  VALUES(" & CI & ",'" & primer_nombre & "','" & segundo_nombre & "','" & primer_apellido & "','" & segundo_apellido & "'," & fecha_con_formato & ",'" & email & "', NULL ,'" & "f" & "'," & "NULL" & ",'" & "Examen Febrero" & "'," & "'" & tipo_persona & "'" & "," & "NULL" & "," & "NULL" & "," & "'f'" & ")"
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function

    Public Function CREAR_ORIENTACION(nombre As String, descripcion As String) As String
        Dim consulta As String = "INSERT INTO Orientaciones (nombre_orientacion , descripcion, baja)
                                  VALUES('" & nombre & "','" & descripcion & "', 'f' )"
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
        End
    End Function
    Public Function CONSULTA_SELECT_ADMINS_ADMINISTRATIVOS() As String
        Return "SELECT CI,tipo,(Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido ) AS nombre_completo,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,fecha_nacimiento,email
                FROM Personas
                WHERE baja = 'f' and (tipo = 'Admin' OR tipo = 'Administrativo' )"
    End Function
    Public Function BAJA_LOGICA_ADMIN(CI As Integer) As String
        Dim consulta As String = "UPDATE Personas SET baja = 't'  WHERE CI = " & CI
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return consulta
    End Function
    Public Function CONSULTAS_TODOS_LOS_GRUPOS() As String
        Return "SELECT id_grupo,foranea_id_instituto,foranea_id_orientacion, nombre_orientacion, ( nombre_orientacion || ' - ' || Institutos.nombre || ' - ' || nombre_grupo ) as Grupo 
                    from Grupos
                    join Institutos on foranea_id_instituto = id_instituto
                    join Orientaciones on foranea_id_orientacion = id_orientacion"
    End Function
    Public Function CONSULTAS_ASIGNAR_ALUMNO_GRUPO(ci As Integer, id_grupo As Integer, id_instituto As Integer) As String
        Dim materias_del_grupo = hacer_consulta(OBTENER_ASIGNATURAS_GRUPO(id_grupo))
        If materias_del_grupo.Rows().Count() = 0 Then
            MsgBox("Parece que el grupo con Id : " & id_grupo & " no tiene asignadas asignaturas!!")
            Return "SELECT 1 FROM (1) as tmp"
        End If
        Dim query As String = ""
        For Each materia In materias_del_grupo.Rows()
            query += vbNewLine & " INSERT INTO Relacion_Alumno_Asignatura_Grupos (foranea_CI_alumno, foranea_id_asignatura, foranea_id_grupo, foranea_id_instituto, nota_final_asignatura, nota_final_asignatura_proyecto)
                        VALUES ( " & ci & " , " & materia.Item("foranea_id_asignatura").ToString() & ", " & id_grupo.ToString() & ", " & id_instituto.ToString() & ", 1, 1) ; " & vbNewLine
        Next
        Console.WriteLine(query)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function CONSULTAS_MODIFICAR_ASIGNACION_ALUMNO_GRUPO(ci As Integer, id_grupo As Integer, id_instituto As Integer) As String
        Dim materias_del_grupo = hacer_consulta(OBTENER_ASIGNATURAS_GRUPO(id_grupo))
        If materias_del_grupo.Rows().Count() = 0 Then
            MsgBox("Parece que el grupo con Id : " & id_grupo & " no tiene asignadas asignaturas!!")
            Return "SELECT max(1) from Institutos;"
        End If
        hacer_consulta(CONSULTAS_DESVINCULAR_ALUMNO_GRUPO(ci))
        Dim query As String = ""
        For Each materia In materias_del_grupo.Rows()
            query += vbNewLine & " INSERT INTO Relacion_Alumno_Asignatura_Grupos (foranea_CI_alumno, foranea_id_asignatura, foranea_id_grupo, foranea_id_instituto, nota_final_asignatura, nota_final_asignatura_proyecto)
                        VALUES ( " & ci & " , " & materia.Item("foranea_id_asignatura").ToString() & ", " & id_grupo.ToString() & ", " & id_instituto.ToString() & ", 1, 1) ; " & vbNewLine
        Next
        Console.WriteLine(query)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function

    Public Function OBTENER_ASIGNATURAS_GRUPO(id_grupo As Integer) As String
        Return "select distinct foranea_id_asignatura 
                    from Relacion_Grupos_Formado_Asignaturas
                    where foranea_id_grupo = " & id_grupo
    End Function

    Public Function CONSULTAS_DESVINCULAR_ALUMNO_GRUPO(ci As Integer) As String
        Dim query As String = "DELETE FROM Relacion_Alumno_Asignatura_Grupos
                where foranea_CI_alumno = " & ci.ToString()
        Console.WriteLine(query)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function

    Public Function CONSULTAS_TODOS_LAS_ASIGNATURAS() As String
        Return "select distinct id_asignatura, ( id_asignatura || ' - ' || nombre_asignatura ) as Asignatura
                    from Asignaturas"

    End Function
    Public Function CONSULTAS_VINCULAR_DOCENTE_A_GRUPO(ci As Integer, id_asignatura As Integer, id_grupo As Integer, id_instituto As Integer) As String
        Dim query As String = "INSERT INTO 
                Relacion_Docente_Asignatura_Grupos (foranea_CI_docente, foranea_id_asignatura, foranea_id_grupo, foranea_id_instituto)
                VALUES ( " & ci.ToString() & " , " & id_asignatura.ToString() & " , " & id_grupo.ToString() & ", " & id_instituto.ToString() & " );"
        Console.WriteLine(query)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function CONSULTA_GRUPOS_ASIGNADOS_DOCENTE(ci As Integer) As String
        Dim query As String = "select  distinct foranea_id_asignatura,foranea_id_grupo,Relacion_Docente_Asignatura_Grupos.foranea_id_instituto as Instituto, ( Institutos.nombre || ' - ' ||  nombre_grupo || ' - ' || nombre_asignatura ) as Asignacion
                                from Relacion_Docente_Asignatura_Grupos 
                                join Asignaturas on id_asignatura =  foranea_id_asignatura
                                join Institutos on id_instituto = foranea_id_instituto
                                join Grupos on foranea_id_grupo = id_grupo
                                where foranea_ci_docente = " & ci & " ;"
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_DESVINCULAR_DOCENTE_GRUPO(id_instituto As Integer, id_grupo As Integer, id_asignatura As Integer) As String
        Dim query As String = "DELETE FROM Relacion_Docente_Asignatura_Grupos
                                WHERE foranea_id_instituto = " & id_instituto &
                                "AND foranea_id_asignatura = " & id_asignatura &
                                "AND foranea_id_grupo = " & id_grupo & ";"
        Console.WriteLine(query)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function CONSULTAS_TODOS_LOS_INSTITUTOS() As String
        Return "select distinct id_instituto,nombre
                from Institutos
                WHERE Institutos.baja = 'f'"
    End Function
    Public Function CONSULTAS_TODAS_LAS_ORIENTACIONES() As String
        Dim query As String = "select distinct id_orientacion,nombre_orientacion
                from Orientaciones
                WHERE Orientaciones.baja = 'f'"
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_ASIGNAR_GRUPO_A_INSTITUTO(id_grupo As Integer, id_instituto As Integer) As String
        Dim query As String = "UPDATE Grupos
                SET foranea_id_instituto = " & id_instituto.ToString() & "
                WHERE id_grupo = " & id_grupo.ToString()
        Console.WriteLine(query)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function
    Public Function CONSULTAS_ASIGNAR_GRUPO_A_ORIENTACION(id_grupo As Integer, id_orientacion As Integer) As String
        Dim query As String = "UPDATE Grupos
                SET foranea_id_orientacion = " & id_orientacion.ToString() & "
                WHERE id_grupo = " & id_grupo.ToString()
        Console.WriteLine(query)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, query, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))
        Return query
    End Function

    Public Function CONSULTAS_ALUMNOS_POR_GRUPO(id_grupo As Integer) As String
        Dim query As String = "SELECT CI, (Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido ) AS nombre_completo,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,fecha_nacimiento,email,hace_proyecto,nota_final_pro,juicio_final
                FROM Personas 
                JOIN (select distinct foranea_ci_alumno, grupos.nombre_grupo 
							from relacion_alumno_asignatura_grupos
							join Grupos on id_grupo = foranea_id_grupo and id_grupo = " & id_grupo.ToString() & "
							order by foranea_ci_alumno) as tmp
				on tmp.foranea_ci_alumno = Personas.CI
                WHERE tipo = 'Alumno' AND baja = 'f'"
        Console.WriteLine(query)

        Return query
    End Function

    Public Function CONSULTAS_NOTAS_DE_ALUMNO_POR_MATERIA(CI As Integer) As String
        Dim query As String = "select Asignaturas.nombre_asignatura,nota_final_asignatura
                                from Relacion_Alumno_Asignatura_Grupos
                                join Asignaturas on Asignaturas.id_asignatura = Relacion_Alumno_Asignatura_Grupos.foranea_id_asignatura
                                where foranea_CI_alumno = " & CI.ToString()
        Console.WriteLine(query)

        Return query
    End Function

    Public Function GUARDAR_HISTORIAL(CI As Integer, IP As String, if_query As String, fecha As String) As String

        Dim query As String = "INSERT INTO Historial (foranea_CI_Persona,IP,query,fecha_hora) 
                                VALUES( " & CI.ToString() & ", '" & IP & "','" & Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(if_query)) & "',TO_DATE ('" & fecha & "','%d-%m-%Y %H:%M:%S'))"
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTA_SELECT_HISTORIAL() As String
        Return "SELECT * FROM Historial"
    End Function
    Public Function GRUPOS_DEL_DOCENTE(ci As Integer) As String
        Dim query As String = "select Relacion_Docente_Asignatura_Grupos.foranea_id_grupo as Id,( Institutos.nombre || ' - ' || Grupos.nombre_grupo || ' - ' || Asignaturas.nombre_asignatura ) as Grupo
                    from Relacion_Docente_Asignatura_Grupos
                    join Grupos on Grupos.id_grupo = foranea_id_grupo
                    join Institutos on Institutos.id_instituto = Relacion_Docente_Asignatura_Grupos.foranea_id_instituto
                    join Asignaturas on Asignaturas.id_asignatura = Relacion_Docente_Asignatura_Grupos.foranea_id_asignatura
                    where Relacion_Docente_Asignatura_Grupos.foranea_CI_docente = " & ci.ToString()
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_PERSONA_EXISTE(ci As Integer) As String
        Dim query As String = "Select count(*) as cant FROM Personas Where CI = " & ci.ToString()
        Console.WriteLine(query)
        Return query
    End Function

    Public Function CONSULTAS_CARAMBULA_1() As String
        Dim query As String = "select ( Personas.primer_nombre || ' ' || 
	     Personas.segundo_nombre || ' ' || 
	     Personas.primer_apellido || ' ' || 
	     Personas.segundo_apellido ) as Nombre_y_apellido
	     from Personas
	     join Relacion_Docente_Trabaja_Instituto R
	     on  R.foranea_ci_docente = Personas.CI and foranea_id_instituto = 1
	     where Personas.baja = 'f'
	     order by Nombre_y_apellido;"
        Console.WriteLine(query)
        Return query
    End Function

    Public Function CONSULTAS_CARAMBULA_2() As String
        Dim query As String = "select Institutos.nombre, (
			select count(*)  FROM ( 
				select distinct foranea_ci_alumno 
				from Relacion_Alumno_Asignatura_Grupos where foranea_id_instituto = Institutos.id_instituto) as cnt_alumnos
			) as Cantidad_Alumnos,
			(
			select count(*)  FROM ( 
				select distinct foranea_ci_docente 
				from Relacion_Docente_Trabaja_Instituto where foranea_id_instituto = Institutos.id_instituto) as cnt_docentes
			) as Cantidad_Docentes,
			(
			select count(*)  FROM ( 
				select distinct foranea_id_grupo 
				from Relacion_Grupos_Formado_Asignaturas where foranea_id_instituto = Institutos.id_instituto) as cnt_docentes
			) as Cantidad_Grupos
		from Institutos
        where Institutos.baja = 'f';"
        Console.WriteLine(query)
        Return query
    End Function

    Public Function CONSULTAS_CARAMBULA_3() As String
        Dim query As String = "select Asignaturas.nombre_asignatura,count(*) as Cantidad_Docentes
		from ( select distinct foranea_ci_docente,foranea_id_asignatura from Relacion_Docente_Asignatura_Grupos ) as docente_asignatura
		join Asignaturas on foranea_id_asignatura = id_asignatura
		where Asignaturas.baja = 'f'
		group by Asignaturas.nombre_asignatura;"
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_CARAMBULA_4() As String
        Dim query As String = "select Asignaturas.nombre_asignatura,
	   ( Personas.primer_nombre || ' ' || 
	     Personas.segundo_nombre || ' ' || 
	     Personas.primer_apellido || ' ' || 
	     Personas.segundo_apellido ) as Nombre_y_apellido
	   from Relacion_Docente_Asignatura_Grupos
	   join Personas on Personas.CI = foranea_ci_docente
	   join Asignaturas on Asignaturas.id_asignatura = foranea_id_asignatura
       where foranea_id_grupo = 4 and Asignaturas.baja = 'f';"
        Console.WriteLine(query)
        Return query
    End Function

    Public Function CONSULTAS_CARAMBULA_5() As String
        Dim query As String = "select Asignaturas.nombre_asignatura,Grupos.nombre_grupo
	   from Relacion_Alumno_Asignatura_Grupos
	   join Asignaturas on Asignaturas.id_asignatura = foranea_id_asignatura
	   join Grupos on Grupos.id_grupo = foranea_id_grupo
	   where foranea_ci_alumno = 31814743 and Asignaturas.baja = 'f';"
        Console.WriteLine(query)
        Return query
    End Function

    Public Function CONSULTAS_CARAMBULA_6() As String
        Dim query As String = "select fecha, categoria, nota
	   from Calificaciones
	   where ci_alumno = 31814743 and Calificaciones.baja = 'f';"
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_CARAMBULA_7() As String
        Dim query As String = "select Asignaturas.nombre_asignatura as Nombre,nota_final_asignatura,
	( CASE
	    when nota_final_asignatura < 4 then 'Examen_Febrero'
    	when nota_final_asignatura >= 4 and  nota_final_asignatura < 8 then 'Examen_Diciembre'
    	when nota_final_asignatura >= 8 then 'Aprobado'
  		end
  	) as Juicio
	from relacion_alumno_asignatura_grupos
	join Asignaturas on Asignaturas.id_asignatura = foranea_id_asignatura
	where foranea_ci_alumno = 39912206 and Asignaturas.baja = 'f';"
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_CARAMBULA_8() As String
        Dim query As String = "select ( Personas.primer_nombre || ' ' || 
	     Personas.segundo_nombre || ' ' || 
	     Personas.primer_apellido || ' ' || 
	     Personas.segundo_apellido ) as Nombre_y_apellido,	   
	Asignaturas.nombre_asignatura as Nombre,nota_final_asignatura,
	( CASE
	    when nota_final_asignatura < 4 then 'Examen_Febrero'
    	when nota_final_asignatura >= 4 and  nota_final_asignatura < 8 then 'Examen_Diciembre'
    	when nota_final_asignatura >= 8 then 'Aprobado'
  		end
  	) as Juicio
	from relacion_alumno_asignatura_grupos
	join Asignaturas on Asignaturas.id_asignatura = foranea_id_asignatura
	join Personas on Personas.CI = foranea_ci_alumno
	where foranea_id_asignatura = 57 and foranea_ci_alumno in ( select distinct foranea_ci_alumno
																from relacion_alumno_asignatura_grupos
																where foranea_id_grupo = 4);"
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_CARAMBULA_9() As String
        Dim query As String = "select ( Personas.primer_nombre || ' ' || 
	     Personas.segundo_nombre || ' ' || 
	     Personas.primer_apellido || ' ' || 
	     Personas.segundo_apellido ) as Nombre_y_apellido,
		(
        select  nvl(avg(nota),1)
          from calificaciones
            where  categoria 
             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
              and  CI_alumno = Personas.CI
		) as Nota_Final_Proyecto
		from Personas where Personas.baja = 'f' and Personas.CI in ( select distinct foranea_ci_alumno
																from relacion_alumno_asignatura_grupos
																where foranea_id_grupo = 4);
"
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_CARAMBULA_10() As String
        Dim query As String = "select I.nombre, 
	nvl(( 
	select avg(avg_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as avg_notas
	),1) as Nota_Promedio,
	nvl(( 
	select max(max_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as max_notas
	),1) as Nota_Maxima,
	nvl(( 
	select min(min_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as min_notas
	),1) as Nota_Minima
	from Institutos I
	order by Nota_Promedio DESC;
"
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_CARAMBULA_11() As String
        Dim query As String = "select I.nombre, 
	nvl(( 
	select avg(avg_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			join Grupos on Grupos.id_grupo = Relacion_Alumno_Asignatura_Grupos.foranea_id_grupo and Grupos.turno = 'Vespertino'
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as avg_notas
	),1) as Nota_Promedio_Vespertino,
	nvl(( 
	select max(max_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			join Grupos on Grupos.id_grupo = Relacion_Alumno_Asignatura_Grupos.foranea_id_grupo and Grupos.turno = 'Vespertino'
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as max_notas
	),1) as Nota_Maxima_Vespertino,
	nvl(( 
	select min(min_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			join Grupos on Grupos.id_grupo = Relacion_Alumno_Asignatura_Grupos.foranea_id_grupo and Grupos.turno = 'Vespertino'
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as min_notas
	),1) as Nota_Minima_Vespertino,
	nvl(( 
	select avg(avg_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			join Grupos on Grupos.id_grupo = Relacion_Alumno_Asignatura_Grupos.foranea_id_grupo and Grupos.turno = 'Matutino'
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as avg_notas
	),1) as Nota_Promedio_Matutino,
	nvl(( 
	select max(max_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			join Grupos on Grupos.id_grupo = Relacion_Alumno_Asignatura_Grupos.foranea_id_grupo and Grupos.turno = 'Matutino'
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as max_notas
	),1) as Nota_Maxima_Matutino,
	nvl(( 
	select min(min_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			join Grupos on Grupos.id_grupo = Relacion_Alumno_Asignatura_Grupos.foranea_id_grupo and Grupos.turno = 'Matutino'
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as min_notas
	),1) as Nota_Minima_Matutino,
	nvl(( 
	select avg(avg_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			join Grupos on Grupos.id_grupo = Relacion_Alumno_Asignatura_Grupos.foranea_id_grupo and Grupos.turno = 'Nocturno'
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as avg_notas
	),1) as Nota_Promedio_Nocturno,
	nvl(( 
	select max(max_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			join Grupos on Grupos.id_grupo = Relacion_Alumno_Asignatura_Grupos.foranea_id_grupo and Grupos.turno = 'Nocturno'
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as max_notas
	),1) as Nota_Maxima_Nocturno,
	nvl(( 
	select min(min_notas.Nota_Final_Proyecto) from (
	select  distinct ( Personas.primer_nombre || ' ' || 
		     Personas.segundo_nombre || ' ' || 
		     Personas.primer_apellido || ' ' || 
		     Personas.segundo_apellido ) as Nombre_y_apellido,
		     (
	        select  nvl(avg(nota),1)
	          from calificaciones
	            where  categoria 
	             in ('Primera_entrega_proyecto','Segunda_entrega_proyecto','Tercera_entrega_proyecto','Defensa_individual','Defensa_grupal','Es_proyecto') 
	              and  CI_alumno = Personas.CI
			) as Nota_Final_Proyecto,
			Institutos.nombre
			from Personas 
			join Relacion_Alumno_Asignatura_Grupos on foranea_ci_alumno = Personas.CI
			join Institutos on Relacion_Alumno_Asignatura_Grupos.foranea_id_instituto = Institutos.id_instituto and Institutos.id_instituto = I.id_instituto
			join Grupos on Grupos.id_grupo = Relacion_Alumno_Asignatura_Grupos.foranea_id_grupo and Grupos.turno = 'Nocturno'
			where EXISTS ( select * from relacion_alumno_asignatura_grupos where foranea_ci_alumno = Personas.CI )
			and Personas.baja = 'f'
		) as min_notas
	),1) as Nota_Minima_Nocturno
	from Institutos I
	order by Nota_Promedio_Vespertino,Nota_Promedio_Matutino,Nota_Promedio_Nocturno DESC;

"
        Console.WriteLine(query)
        Return query
    End Function

    Public Function CONSULTAS_CARAMBULA_12() As String
        Dim query As String = "select distinct tmp.nombre_y_apellido,Institutos.nombre,tmp.Promedio,Grupos.nombre_grupo,Grupos.turno
from 
Institutos
left join (
select  
		Institutos.id_instituto,
		Institutos.nombre,
		Personas.CI,
		( Personas.primer_nombre || ' ' || 
	     Personas.segundo_nombre || ' ' || 
	     Personas.primer_apellido || ' ' || 
	     Personas.segundo_apellido ) as Nombre_y_apellido,
	     (
	     select avg(nota)
			from Calificaciones
			where Calificaciones.ci_alumno = Personas.CI
	     	) as Promedio
	    from Institutos
	    join Relacion_Alumno_Asiste_Instituto on Relacion_Alumno_Asiste_Instituto.foranea_id_instituto = Institutos.id_instituto 
	    	-- and Relacion_Alumno_Asiste_Instituto.foranea_ci_alumno = Personas.CI 
	    join Personas on Personas.CI = Relacion_Alumno_Asiste_Instituto.foranea_ci_alumno 
	    	and Personas.CI = (
				select ci_alumno from 
					( select first 1 ci_alumno,avg(nota) as Promedio
						from Calificaciones
						where Calificaciones.id_instituto = Institutos.id_instituto
						group by ci_alumno
						order by Promedio desc ) as avg_nota
					)
	  ) as tmp  on tmp.id_instituto = Institutos.id_instituto   
	 left join Personas on Personas.CI = tmp.CI
	 left join relacion_alumno_asignatura_grupos on relacion_alumno_asignatura_grupos.foranea_ci_alumno = Personas.CI
	 left join Grupos on Grupos.id_grupo = relacion_alumno_asignatura_grupos.foranea_id_grupo
	 where Institutos.baja = 'f'
	 order by tmp.Promedio desc;
"
        Console.WriteLine(query)
        Return query
    End Function

    Public Function CONSULTAS_CARAMBULA_13() As String
        Dim query As String = "
select sumario_promedios.nombre_instituto,sumario_promedios.nombre_grupo,sumario_personas.turno,max_promedio
from 
(
select nombre_instituto,nombre_grupo,max(promedio) as max_promedio 
from ( 
select Personas.CI,
		( Personas.primer_nombre || ' ' || 
	     Personas.segundo_nombre || ' ' || 
	     Personas.primer_apellido || ' ' || 
	     Personas.segundo_apellido ) as Nombre_y_apellido,
	     Institutos.nombre as nombre_instituto,
	     Grupos.nombre_grupo,
	     (select avg(nota) from Calificaciones where ci_alumno = Personas.CI) as Promedio
	     from Personas
	     join (select distinct foranea_ci_alumno,foranea_id_grupo,foranea_id_instituto from relacion_alumno_asignatura_grupos) as sumario_ins_grupos
	     on sumario_ins_grupos.foranea_ci_alumno = Personas.CI
	     join Institutos on Institutos.id_instituto = sumario_ins_grupos.foranea_id_instituto
	     join Grupos on Grupos.id_grupo = sumario_ins_grupos.foranea_id_grupo
	     order by Promedio DESC
	    ) as sumario_final
	    group by nombre_instituto,nombre_grupo
	    order by max_promedio   
) as sumario_promedios
join (
select Personas.CI,
		( Personas.primer_nombre || ' ' || 
	     Personas.segundo_nombre || ' ' || 
	     Personas.primer_apellido || ' ' || 
	     Personas.segundo_apellido ) as Nombre_y_apellido,
	     Institutos.nombre as nombre_instituto,
	     Grupos.nombre_grupo,
	     Grupos.Turno,
	     (select avg(nota) from Calificaciones where ci_alumno = Personas.CI) as Promedio
	     from Personas
	     join (select distinct foranea_ci_alumno,foranea_id_grupo,foranea_id_instituto from relacion_alumno_asignatura_grupos) as sumario_ins_grupos
	     on sumario_ins_grupos.foranea_ci_alumno = Personas.CI
	     join Institutos on Institutos.id_instituto = sumario_ins_grupos.foranea_id_instituto
	     join Grupos on Grupos.id_grupo = sumario_ins_grupos.foranea_id_grupo
		) as sumario_personas 
on sumario_promedios.max_promedio = sumario_personas.Promedio and sumario_promedios.nombre_instituto = sumario_personas.nombre_instituto
and sumario_promedios.nombre_grupo = sumario_personas.nombre_grupo
"
        Console.WriteLine(query)
        Return query
    End Function

    Public Function CONSULTAS_CARAMBULA_14() As String
        Dim query As String = "
select Grupos.nombre_grupo,
	   Personas.CI,
	   ( Personas.primer_nombre || ' ' || 
	     Personas.segundo_nombre || ' ' || 
	     Personas.primer_apellido || ' ' || 
	     Personas.segundo_apellido ) as Nombre_y_apellido	     
from Personas
join (select distinct foranea_id_grupo,foranea_ci_alumno from relacion_alumno_asignatura_grupos ) as tmp
on tmp.foranea_ci_alumno = Personas.CI
join Grupos on Grupos.id_grupo = tmp.foranea_id_grupo
where tipo = 'Alumno' and Personas.baja = 'f'
and not exists (
	select * from Calificaciones where ci_alumno = Personas.CI 
	and categoria in ( 'Primera_entrega_proyecto',
					   'Segunda_entrega_proyecto',
					   'Tercera_entrega_proyecto',
					   'Defensa_individual', 
					   'Defensa_grupal', 
					   'Es_proyecto'))
"
        Console.WriteLine(query)
        Return query
    End Function

    Public Function CONSULTAS_CARAMBULA_15() As String
        Dim query As String = "select ( Personas.primer_nombre || ' ' || 
	     Personas.segundo_nombre || ' ' || 
	     Personas.primer_apellido || ' ' || 
	     Personas.segundo_apellido ) as Nombre_y_apellido,
	     Personas.grado,
	     (
	     	select count(*)
	     		from ( select distinct foranea_id_asignatura 
	     					from Relacion_Docente_Asignatura_Grupos where
	     					foranea_ci_docente = Personas.CI ) as materias
	     ) as Cantidad_Asignaturas,
	     (
	     	select count(*)
	     		from ( select distinct foranea_id_grupo 
	     					from Relacion_Docente_Asignatura_Grupos where
	     					foranea_ci_docente = Personas.CI ) as materias
	     ) as Cantidad_Grupos
	     from Personas
	     where tipo = 'Docente' and baja = 'f';
	    
"
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_CARAMBULA_16() As String
        Dim query As String = "select Institutos.nombre,
	        Orientaciones.nombre_orientacion,
	        (
	        select count(*) 
		        from Grupos 
		        where foranea_id_instituto = Institutos.id_instituto and foranea_id_orientacion = 12
	        ) as Cantidad_Grupos
	        from Institutos
	        join Orientaciones on Orientaciones.id_orientacion = 12
	        where exists (
		        select * from Grupos where foranea_id_instituto = Institutos.id_instituto and foranea_id_orientacion = 12 )
		        and Institutos.baja = 'f';		
    "
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_CARAMBULA_17() As String
        Dim query As String = "select * from Historial
	        where foranea_CI_Persona = 48914198
	        order by fecha_hora;
            "
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CONSULTAS_CARAMBULA_18() As String
        Dim query As String = "select * from Historial
	            where fecha_hora > TO_DATE('10-28-1986','%m-%d-%Y') and fecha_hora < TO_DATE('01-01-2040','%m-%d-%Y')
	            order by fecha_hora;
                        "
        Console.WriteLine(query)
        Return query
    End Function
    Public Function CREAR_CIUDAD(nombre As String, departamento As String) As String
        Dim consulta As String = "INSERT INTO Ciudad (nombre_ciudad , nombre_departamento , baja)
                VALUES('" & nombre & "','" & departamento & "','" & "f" & "')"
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))

        Return consulta
    End Function

    Public Function CREAR_INSTITUTO(nombre As String, calle As String, numero As Integer, email As String, telefonos As String, id_ciudad As Integer) As String
        Dim consulta As String = "INSERT INTO Institutos (nombre , calle, numero,telefonos, email , foranea_id_ciudad, baja)
                VALUES('" & nombre & "','" & calle & "'," & numero &
                ",'" & email &
                & ",'" & telefonos & "'," & id_ciudad &
                ",'" & "f" & "')"
        Console.WriteLine(consulta)
        hacer_consulta(GUARDAR_HISTORIAL(USUARIO_LOGUEADO.CI, USUARIO_LOGUEADO.IPAddress, consulta, Date.Now.ToString("dd-MM-yyyy HH:MM:ss", CultureInfo.InvariantCulture)))

        Return consulta
    End Function

    Public Function CONSULTAS_COMBO_CIUDADES() As String
        Dim consulta As String = "
            select id_ciudad,( id_ciudad || ' - ' || nombre_ciudad) as nombre
	            from Ciudad
	            where baja = 'f'"
        Console.WriteLine(consulta)
        Return consulta
    End Function

End Module
