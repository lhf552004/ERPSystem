
alter table [Statistics] 
--add constraint FK_Ingr_Prod foreign key(Pro_OID) references Product(OID)
--add constraint FK_Ingr_Rec foreign key(Rec_OID) references Receival(OID)
add constraint FK_Sta_War foreign key(War_OID) references Warehouse(OID)