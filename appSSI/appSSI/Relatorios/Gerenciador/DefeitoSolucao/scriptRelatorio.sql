drop function popula_defeito_solucao;
/
drop type t_type_defeito_solucao;
/
create or replace type type_defeito_solucao as object
	(
		cdSistema   NUMBER, 
		nmSistema   VARCHAR2(45), 
		cdModulo    NUMBER,
		nmModulo    VARCHAR2(60), 
		cdTela      NUMBER, 
		nmTela      VARCHAR2(30), 
		cdAcao      NUMBER, 
		deAcao      VARCHAR2(30), 
    cdDefeito   NUMBER,
		deSolucao   VARCHAR2(4000), 
		flNivel     VARCHAR2(1), 
		descDefeito VARCHAR(4000),
		pcdSistema VARCHAR2(200),
		pcdModulo  VARCHAR2(200),
		pcdTela    VARCHAR2(200),
		pcdAcao    VARCHAR2(200)
	);
/
create or replace type t_type_defeito_solucao as table of type_defeito_solucao;
/
create or replace function get_defeito_solucao(
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
           de.cdDefeito,
           so.deSolucao,
           so.flNivel,
           de.deDefeito,
           CASE WHEN pcdSistema = 0 THEN
             'Todos'
           ELSE
             s.cdSistema || ' - ' || s.nmSistema
           END AS pcdSistema,
           CASE WHEN pcdModulo = 0 THEN
             'Todos'
           ELSE
             m.cdModulo || ' - ' || m.nmModulo
           END AS pcdModulo,
           CASE WHEN pcdTela = 0 THEN
             'Todas'
           ELSE
             t.cdTela || ' - ' || t.nmTela
           END AS pcdTela,
           CASE WHEN pcdAcao = 0 THEN
             'Todas'
           ELSE
             ac.cdAcao || ' - ' || ac.deAcao
           END AS pcdAcao
      from sistemas s
     inner join modulos m on m.cdSistema = s.cdSistema
     inner join telas t on t.cdModulo = m.cdModulo
     inner join telas_acoes ta on ta.cdTela = t.cdTela
     inner join acoes ac on ac.cdAcao = ta.cdAcao
     inner join telas_defeitos td on td.cdTela = ta.cdTela and td.cdAcao = ta.cdAcao
     inner join defeitos de on de.cdDefeito = td.cdDefeito
      left join solucoes_defeitos sd on sd.cdDefeito = td.cdDefeito
      left join solucoes so on so.cdSolucao = sd.cdSolucao
     where (s.cdSistema = pcdSistema or pcdSistema = 0)
       and (m.cdModulo  = pcdModulo or pcdModulo = 0)
       and (t.cdTela    = pcdTela or pcdTela = 0)
       and (ac.cdAcao   = pcdAcao or pcdAcao = 0);
    
  return crReult;
    
  return crReult;
end get_defeito_solucao;
/
create or replace function popula_defeito_solucao(
    pcdSistema IN sistemas.cdSistema%TYPE,
    pcdModulo  IN modulos.cdModulo%TYPE,
    pcdTela    IN telas.cdTela%TYPE,
    pcdAcao    IN acoes.cdAcao%TYPE 
)
  return t_type_defeito_solucao is
  v_emptype t_type_defeito_solucao := t_type_defeito_solucao();
  v_rc      sys_refcursor; 
  v_cnt     number := 0;

  --Paramtros
  v_pcdSistema VARCHAR2(200); 
  v_pcdModulo  VARCHAR2(200); 
  v_pcdTela    VARCHAR2(200); 
  v_pcdAcao    VARCHAR2(200); 

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
  v_deDefeito defeitos.deDefeito%TYPE;
  v_cdDefeito defeitos.cdDefeito%TYPE;
  begin
    v_rc := get_defeito_solucao(pcdSistema, pcdModulo, pcdTela, pcdAcao);
	
    loop
      fetch v_rc into 
        v_cdSistema, 
        v_nmSistema, 
        v_cdModulo, 
        v_nmModulo, 
        v_cdTela, 
        v_nmTela, 
        v_cdAcao, 
        v_deAcao, 
        v_cdDefeito,
        v_deSolucao, 
        v_flNivel, 
        v_deDefeito,
        v_pcdSistema,
        v_pcdModulo,
        v_pcdTela,
        v_pcdAcao;
      
      exit when v_rc%NOTFOUND;
      v_emptype.extend;
      v_cnt := v_cnt + 1;
      v_emptype(v_cnt) := type_defeito_solucao(v_cdSistema, 
                                                 v_nmSistema, 
                                                 v_cdModulo, 
                                                 v_nmModulo, 
                                                 v_cdTela, 
                                                 v_nmTela, 
                                                 v_cdAcao, 
                                                 v_deAcao, 
                                                 v_cdDefeito,
                                                 v_deSolucao, 
                                                 v_flNivel, 
                                                 v_deDefeito,
                                                 v_pcdSistema,
                                                 v_pcdModulo,
                                                 v_pcdTela,
                                                 v_pcdAcao);
    end loop;
    close v_rc;
    return v_emptype;
 end;
 /