drop function popula_sol_cons_temp_cad;
/
drop type t_type_sol_cons_temp_cad;
/
create or replace type type_sol_cons_temp_cad as object
	(
      cdSistema NUMBER, 
      nmSistema VARCHAR2(45), 
      cdModulo  NUMBER,
      nmModulo  VARCHAR2(60), 
      cdTela    NUMBER, 
      nmTela    VARCHAR2(30), 
      cdAcao    NUMBER, 
      deAcao    VARCHAR2(30), 
      deSolucao VARCHAR2(4000), 
      flNivel   VARCHAR2(1), 
      qtd       NUMBER
	);
/
create or replace type t_type_sol_cons_temp_cad as table of type_sol_cons_temp_cad;
/
create or replace function get_sol_cons_temp_cad(
    pcdSistema IN sistemas.cdSistema%TYPE,
    pcdModulo  IN modulos.cdModulo%TYPE,
    pcdTela    IN telas.cdTela%TYPE,
    pcdAcao    IN acoes.cdAcao%TYPE
  )
  return sys_refcursor
AS
  crReult sys_refcursor;
begin
  open crReult for 
    select s.cdSistema, 
           s.nmSistema, 
           m.cdModulo, 
           m.nmModulo, 
           t.cdTela, 
           t.nmTela, 
           ac.cdAcao, 
           ac.deAcao,
           so.deSolucao,
           so.flNivel,
           nvl(ind.qtd, 0) qtd
      from sistemas s
     inner join modulos m on m.cdSistema = s.cdSistema
     inner join telas t on t.cdModulo = m.cdModulo
     inner join telas_acoes ta on ta.cdTela = t.cdTela
     inner join acoes ac on ac.cdAcao = ta.cdAcao
     inner join telas_defeitos td on td.cdTela = ta.cdTela and td.cdAcao = ta.cdAcao
     inner join solucoes_defeitos sd on sd.cdDefeito = td.cdDefeito
     inner join solucoes so on so.cdSolucao = sd.cdSolucao
      left join (select count(1) qtd, cdSolucao from indicadores group by cdSolucao) ind on ind.cdSolucao = so.cdSolucao
     where s.cdSistema = pcdSistema
       and m.cdModulo  = pcdModulo
       and t.cdTela    = pcdTela
       and ac.cdAcao   = pcdAcao;
    
  return crReult;
end get_sol_cons_temp_cad;
/
create or replace function popula_sol_cons_temp_cad(
    pcdSistema IN sistemas.cdSistema%TYPE,
    pcdModulo  IN modulos.cdModulo%TYPE,
    pcdTela    IN telas.cdTela%TYPE,
    pcdAcao    IN acoes.cdAcao%TYPE 
)
  return t_type_sol_cons_temp_cad is
  v_emptype t_type_sol_cons_temp_cad := t_type_sol_cons_temp_cad();
  v_rc      sys_refcursor; 
  v_cnt     number := 0;

  v_cdSistema sistemas.cdSistema%TYPE;
  v_nmSistema sistemas.nmSistema%TYPE; 
  v_cdModulo  modulos.cdModulo%TYPE; 
  v_nmModulo  modulos.nmModulo%TYPE; 
  v_cdTela    telas.cdTela%TYPE; 
  v_nmTela    telas.nmTela%TYPE; 
  v_cdAcao    acoes.cdAcao%TYPE; 
  v_deAcao    acoes.deAcao%TYPE;
  v_deSolucao solucoes.deSolucao%TYPE;
  v_flNivel   solucoes.flNivel%TYPE;
  v_qtd       NUMBER;
  begin
    v_rc := get_sol_cons_temp_cad(pcdSistema, pcdModulo, pcdTela, pcdAcao);
	
    loop
      fetch v_rc into v_cdSistema, v_nmSistema, v_cdModulo, v_nmModulo, v_cdTela, v_nmTela, v_cdAcao, v_deAcao, v_deSolucao, v_flNivel, v_qtd;
      
      exit when v_rc%NOTFOUND;
      v_emptype.extend;
      v_cnt := v_cnt + 1;
      v_emptype(v_cnt) := type_sol_cons_temp_cad(v_cdSistema, v_nmSistema, v_cdModulo, v_nmModulo, v_cdTela, v_nmTela, v_cdAcao, v_deAcao, v_deSolucao, v_flNivel, v_qtd);
    end loop;
    close v_rc;
    return v_emptype;
 end;
 /