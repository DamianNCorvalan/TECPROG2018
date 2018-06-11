/*   SCRIPT SQL  - Tablas con Restricciones -   */
Use LOMAAAAAAAAAAAA;

CREATE TABLE PERSONAS
       (
       ID_PERSONA BIGINT NOT NULL,                              
       NOMBRE CHAR(30) NOT NULL,                              
       APELLIDO CHAR(30) NOT NULL,                              
       PRIMARY KEY
               (
               ID_PERSONA
               )
       );



CREATE TABLE PROVINCIAS
       (
       ID_PROVINCIA BIGINT NOT NULL,                              
       NOM_PROV CHAR(20) NOT NULL,                              
       PRIMARY KEY
               (
               ID_PROVINCIA
               )
       );



CREATE TABLE PRODUCTOS
       (
       ID_PRODUCTO BIGINT NOT NULL,                              
       DESCRIPCION CHAR(20) NOT NULL,                              
       PRECIO MONEY NOT NULL,                              
       STOCK BIGINT NOT NULL,                              
       PRIMARY KEY
               (
               ID_PRODUCTO
               )
       );



CREATE TABLE TELEFONOS
       (
       ID_TELEFONO BIGINT NOT NULL,                              
       ID_PERSONA BIGINT NOT NULL,                              
       NUMERO_TEL INT NOT NULL,                              
       PRIMARY KEY
               (
               ID_TELEFONO,
               ID_PERSONA
               ),
       FOREIGN KEY
               (
               ID_PERSONA
               )
          REFERENCES PERSONAS
               (
               ID_PERSONA
               )
       );



CREATE TABLE EMPLEADOS
       (
       ID_PERSONA BIGINT NOT NULL,                              
       ID_EMPLEADOS INT NOT NULL,                              
       PRIMARY KEY
               (
               ID_PERSONA
               ),
       FOREIGN KEY
               (
               ID_PERSONA
               )
          REFERENCES PERSONAS
               (
               ID_PERSONA
               )
       );



CREATE TABLE CLIENTES
       (
       ID_PERSONA BIGINT NOT NULL,                              
       ID_CLIENTE INT NOT NULL,                              
       PRIMARY KEY
               (
               ID_PERSONA
               ),
       FOREIGN KEY
               (
               ID_PERSONA
               )
          REFERENCES PERSONAS
               (
               ID_PERSONA
               )
       );



CREATE TABLE LOCALIDADES
       (
       ID_LOCALIDAD BIGINT NOT NULL,                              
       ID_PROVINCIA BIGINT NOT NULL,                              
       LOCALIDAD CHAR(20) NOT NULL,                              
       PRIMARY KEY
               (
               ID_LOCALIDAD
               ),
       FOREIGN KEY
               (
               ID_PROVINCIA
               )
          REFERENCES PROVINCIAS
               (
               ID_PROVINCIA
               )
       );



CREATE TABLE DIRECCIONES
       (
       ID_DIRECCION BIGINT NOT NULL,                              
       ID_PERSONA BIGINT NOT NULL,                              
       ID_LOCALIDAD BIGINT NOT NULL,                              
       CALLE CHAR(30) NOT NULL,                              
       NRO BIGINT NOT NULL,                              
       BARRIO CHAR(20) NOT NULL,                              
       MANZANA CHAR(20) NOT NULL,                              
       PRIMARY KEY
               (
               ID_DIRECCION,
               ID_PERSONA
               ),
       FOREIGN KEY
               (
               ID_PERSONA
               )
          REFERENCES PERSONAS
               (
               ID_PERSONA
               ),
       FOREIGN KEY
               (
               ID_LOCALIDAD
               )
          REFERENCES LOCALIDADES
               (
               ID_LOCALIDAD
               )
       );



CREATE TABLE FACTURAS
       (
       NRO_FACTURAS BIGINT NOT NULL,                              
       TIPO CHAR(2) NOT NULL,                              
       ID_PERSONA BIGINT NOT NULL,                              
       FECHA DATETIME NOT NULL,                              
       PRIMARY KEY
               (
               NRO_FACTURAS,
               TIPO
               ),
       FOREIGN KEY
               (
               ID_PERSONA
               )
          REFERENCES CLIENTES
               (
               ID_PERSONA
               )
       );



CREATE TABLE DETALLE
       (
       ID_DETALLE BIGINT NOT NULL,                              
       NRO_FACTURAS BIGINT NOT NULL,                              
       TIPO CHAR(2) NOT NULL,                              
       ID_PRODUCTO BIGINT NOT NULL,                              
       CANTIDAD BIGINT NOT NULL,                              
       TOTAL MONEY NOT NULL,                              
       PRIMARY KEY
               (
               ID_DETALLE,
               NRO_FACTURAS,
               TIPO
               ),
       FOREIGN KEY
               (
               NRO_FACTURAS,
               TIPO
               )
          REFERENCES FACTURAS
               (
               NRO_FACTURAS,
               TIPO
               ),
       FOREIGN KEY
               (
               ID_PRODUCTO
               )
          REFERENCES PRODUCTOS
               (
               ID_PRODUCTO
               )
       );



