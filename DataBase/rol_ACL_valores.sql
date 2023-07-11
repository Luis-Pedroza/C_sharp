use votaciones;
go

INSERT INTO rol (nombre, fecha, contrasena) VALUES ('ciudadano', getdate(), null);
INSERT INTO rol (nombre, fecha, contrasena) VALUES ('candidato', getdate(), null);
INSERT INTO rol (nombre, fecha, contrasena) VALUES ('administrador', getdate(), 'password');
INSERT INTO rol (nombre, fecha, contrasena) VALUES ('presidente', getdate(), 'password');
INSERT INTO rol (nombre, fecha, contrasena) VALUES ('secretario', getdate(), 'password');
INSERT INTO rol (nombre, fecha, contrasena) VALUES ('escrutador', getdate(), 'password');
INSERT INTO ACL (nombre,fecha) VALUES ('lectura',getdate());
INSERT INTO ACL (nombre,fecha) VALUES ('escritura',getdate());
INSERT INTO rol_ACL (ROLid, ACLid) VALUES(3, 1);

