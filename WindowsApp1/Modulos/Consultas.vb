﻿Module Consultas

    Public uno As New Integer
    Public dos As New Integer
    Public tres As New Integer

    Public Function CONSULTAS_SELECT_ALUMNOS() As String
        Return "SELECT CI,(Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido ) AS nombre_completo,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,fecha_nacimiento,email,hace_proyecto,nota_final_pro,juicio_final
                FROM Personas 
                WHERE tipo = 'Alumno' AND baja = 'f'"
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
                WHERE tipo = 'Profesor' AND baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_GRUPOS() As String
        Return "SELECT Grupos.id_grupo,Grupos.nombre_grupo,Grupos.turno,Institutos.id_instituto,Institutos.nombre,Orientaciones.id_orientacion,Orientaciones.nombre_orientacion 
                FROM Grupos,Institutos,Orientaciones 
                WHERE Grupos.baja = 'f' and Grupos.foranea_id_instituto = Institutos.id_instituto and Grupos.foranea_id_orientacion = Orientaciones.id_orientacion and  Grupos.baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_ADMINISTRADORES() As String
        Return "SELECT CI,(Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido ) AS nombre_completo,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,fecha_nacimiento,email
                FROM Personas 
                WHERE tipo = 'Administrador' AND baja = 'f'"
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
                FROM Calificaciones,Asignaturas,Grupos,Institutos
                WHERE Calificaciones.baja = 'f' 
                and Asignaturas.id_asignatura =  Calificaciones.id_asignatura 
                and Grupos.id_grupo = Calificaciones.id_grupo
		and Institutos.id_instituto = Calificaciones.id_instituto
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
                WHERE baja = 'f' AND tipo IN ('Admin','Profesor','Administrativo')"
    End Function

    Public Function CREAR_USUARIO(CI As Integer, hash As String, sal As String) As String
        Return "UPDATE Personas SET encriptacion_hash = '" & hash & "',encriptacion_sal = '" & sal & "'  WHERE CI = " & CI
    End Function
    Public Function BAJA_LOGICA_USUARIO(CI As Integer) As String
        Return "UPDATE Personas SET encriptacion_hash = null,encriptacion_sal = null  WHERE CI = " & CI
    End Function
    Public Function BAJA_LOGICA_ALUMNO(CI As Integer) As String
        Return "UPDATE Personas SET baja = 't'  WHERE CI = " & CI
    End Function
    Public Function BAJA_LOGICA_GRUPO(id_grupo As Integer) As String
        Return "UPDATE Grupos SET baja = 't'  WHERE id_grupo = " & id_grupo
    End Function
    Public Function BAJA_LOGICA_ASIGNATURA(id_asignatura As Integer) As String
        Return "UPDATE Asignaturas SET baja = 't'  WHERE id_asignatura = " & id_asignatura
    End Function
    Public Function BAJA_LOGICA_CALIFICACION(id_calificacion As Integer) As String
        Return "UPDATE Calificaciones SET baja = 't'  WHERE id_calificacion = " & id_calificacion
    End Function
    Public Function BAJA_LOGICA_DOCENTE(CI As Integer) As String
        Return "UPDATE Personas SET baja = 't'  WHERE CI = " & CI
    End Function
    Public Function BAJA_LOGICA_INSTITUTO(id_instituto As Integer) As String
        Return "UPDATE Institutos SET baja = 't'  WHERE id_instituto = " & id_instituto
    End Function
    Public Function BAJA_LOGICA_ORIENTACION(id_orientacion As Integer) As String
        Return "UPDATE Orientaciones SET baja = 't'  WHERE id_orientacion = " & id_orientacion
    End Function
    Public Function BAJA_LOGICA_CIUDAD(id_ciudad As Integer) As String
        Return "UPDATE Ciudad SET baja = 't'  WHERE id_ciudad = " & id_ciudad
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

        Return consulta
    End Function

    Public Function MODIFICAR_ADMIN_ADMINISTRATIVO(CI_original As Integer, un_admin As DataGridViewRow, convertir_fecha_ingles As Boolean) As String
        Dim fecha_con_formato As String
        Dim hace_proyecto_como_letra As String = "t"
        Console.WriteLine("SABELO!!!!!!!!!!!!!!!! " & un_admin.Cells("fecha_nacimiento").Value().GetType().ToString())
        Console.WriteLine("SABELO!!!!!!!!!!!!!!!! " & un_admin.Cells("fecha_nacimiento").Value().ToString())
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
        Return consulta
    End Function

    Public Function MODIFICAR_ALUMNO(CI_original As Integer, alumno As DataGridViewRow, convertir_fecha_ingles As Boolean) As String
        Dim fecha_con_formato As String
        Dim hace_proyecto_como_letra As String = "t"
        Console.WriteLine("SABELO!!!!!!!!!!!!!!!! " & alumno.Cells("fecha_nacimiento").Value().GetType().ToString())
        Console.WriteLine("SABELO!!!!!!!!!!!!!!!! " & alumno.Cells("fecha_nacimiento").Value().ToString())
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
        Return consulta
    End Function
    Public Function MODIFICAR_GRUPO(id_grupo_original As Integer, Grupo As DataGridViewRow, id_instituto As Integer, id_orientacion As Integer) As String
        Dim consulta As String = "UPDATE Grupos SET " &
                " turno = '" & Grupo.Cells("turno").Value() & "'," &
                " foranea_id_instituto  = " & id_instituto & "," &
                " foranea_id_orientacion  = " & id_orientacion & "," &
                " WHERE id_grupo = " & id_grupo_original
        Console.WriteLine(consulta)
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
                VALUES(" & CI & ",'" & primer_nombre & "','" & segundo_nombre & "','" & primer_apellido & "','" & segundo_apellido & "'," & fecha_con_formato & ",'" & email & "'," & grado & ",'" & "f" & "'," & "NULL" & "," & "Examen Febrero" & "," & "'Profesor'" & "," & "NULL" & "," & "NULL" & "," & "'f'" & ")"
        Console.WriteLine(consulta)
        Return consulta
    End Function
    Public Function CREAR_GRUPO(nombre As String, turno As String, id_instituto As Integer, id_orientacion As Integer) As String


        Dim consulta As String = "INSERT INTO Grupos (foranea_id_instituto, nombre_grupo, turno, baja, foranea_id_orientacion)
                VALUES(" & id_instituto & ",'" & nombre & "','" & turno & "','" & "f" & "'," & id_orientacion & ")"
        Console.WriteLine(consulta)

        Return consulta
    End Function
    Public Function CREAR_ASIGNATURA(nombre As String, descripcion As String) As String


        Dim consulta As String = "INSERT INTO Asignaturas (nombre_asignatura  , descripcion, baja)
                VALUES('" & nombre & "','" & descripcion & "'," & "'f'" & ")"
        Console.WriteLine(consulta)

        Return consulta
    End Function
    Public Function MODIFICAR_ASIGNATURA(asignatura As DataGridViewRow) As String

        Dim consulta As String = "UPDATE Asignaturas SET " &
                " nombre_asignatura = '" & asignatura.Cells("nombre_asignatura").Value() & "'," &
                " descripcion = '" & asignatura.Cells("descripcion").Value() & "'" &
                " WHERE id_asignatura = " & asignatura.Cells("id_asignatura").Value()
        Console.WriteLine(consulta)
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
        and foranea_ci_docente = " & USUARIO_LOGUEADO.CI & "
        and B.foranea_id_instituto =" & resultado2



    End Function

    Public Function COMBOBOX_CALIFICACIONES_COMPLETA(cboAsignatura As ComboBox, cboInstituto As ComboBox, cboGrupo As ComboBox) As String

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
       from calificaciones a
       where a.baja = 'f' 
       and ci_docente = " & USUARIO_LOGUEADO.CI & "
       and a.id_grupo = " & dos & "
       and a.id_instituto = " & uno & "
       and a.id_asignatura = " & tres

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
            tipo_persona = "Administrador"
        End If
        If convertir_fecha_ingles Then
            fecha_con_formato = fecha_nacimiento.ToString("dd/MM/yyyy")
        Else
            fecha_con_formato = fecha_nacimiento.ToString("MM/dd/yyyy")
        End If
        Dim consulta As String = "INSERT INTO Personas (CI, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, fecha_nacimiento, email, grado, hace_proyecto, nota_final_pro, juicio_final, tipo, encriptacion_hash, encriptacion_sal, baja)
                                  VALUES(" & CI & ",'" & primer_nombre & "','" & segundo_nombre & "','" & primer_apellido & "','" & segundo_apellido & "'," & fecha_con_formato & ",'" & email & "', NULL ,'" & "f" & "'," & "NULL" & ",'" & "Examen Febrero" & "'," & "'" & tipo_persona & "'" & "," & "NULL" & "," & "NULL" & "," & "'f'" & ")"
        Console.WriteLine(consulta)
        Return consulta
    End Function

    Public Function CONSULTA_SELECT_ADMINS_ADMINISTRATIVOS() As String
        Return "SELECT CI,tipo,(Personas.primer_nombre || ' ' || Personas.segundo_nombre || ' ' || Personas.primer_apellido || ' ' || Personas.segundo_apellido ) AS nombre_completo,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,fecha_nacimiento,email
                FROM Personas
                WHERE baja = 'f' and (tipo = 'Admin' OR tipo = 'Administrador' )"
    End Function
    Public Function BAJA_LOGICA_ADMIN(CI As Integer) As String
        Return "UPDATE Personas SET baja = 't'  WHERE CI = " & CI
    End Function
End Module
