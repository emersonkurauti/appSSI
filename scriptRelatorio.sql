drop function popula_/*sulfixo*/;
/
drop type t_type_/*sulfixo*/;
/
create or replace type type_/*sulfixo*/ as object
	(
		/*campo*/
	);
/
create or replace type t_type_/*sulfixo*/ as table of type_/*sulfixo*/;
/
create or replace function get_/*sulfixo*/
  return sys_refcursor
AS
  crReult sys_refcursor;
begin
  open crReult for 
    /*Select cdSolucao from solucoes;*/
    
  return crReult;
end get_/*sulfixo*/;
/
create or replace function popula_/*sulfixo*/(/*Parametros*/)
  return t_type_/*sulfixo*/ is
  v_emptype t_type_/*sulfixo*/ := t_type_/*sulfixo*/();
  v_rc      sys_refcursor; 
  v_cnt     number := 0;

  /*campo number;*/
  begin
    v_rc := get_/*sulfixo*/;
	
    loop
      fetch v_rc into /*campo, campo*/;
      
      exit when v_rc%NOTFOUND;
      v_emptype.extend;
      v_cnt := v_cnt + 1;
      v_emptype(v_cnt) := type_/*sulfixo*/(/*campo, campo*/);
    end loop;
    close v_rc;
    return v_emptype;
 end;
 /