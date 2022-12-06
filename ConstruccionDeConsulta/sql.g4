grammar sql;

sql : tabla 
    | tabla tabla
    | innerkw
    | leftkw
    | rightkw
    ;

tabla : columna ;

innerkw : columna_p (SEP LCURLY columna RCURLY)? AND 
(SEP LCURLY columna RCURLY)? ;

leftkw : campo (LCURLY campo RCURLY)? LT 
(LCURLY campo RCURLY)? ;

rightkw : campo (LCURLY campo RCURLY)? GT 
(LCURLY campo RCURLY)? ;

columna: TEXT (BRACKET_AB campo BRACKET_CE)? 
(SEP BRACKET_AB campo BRACKET_CE)? 
(SEP BRACKET_AB campo BRACKET_CE)?;

campo: TEXT
    | (DOT TEXT)+
    ;

columna_p : (DOT TEXT) ;

LCURLY : '{' ;
RCURLY : '}' ;

QUOTE: '\'';
BRACKET_AB : '[' ;
BRACKET_CE : ']' ;
SEP : ',' ;
PAREN_AB : '(' ;
PAREN_CE : ')' ;
COMI : '"' ;
DOT : '.' ;
TEXT : [A-Za-z_] [A-Za-z0-9_]+ ;
IG : '=' ;
SUM: '+' ;
LT : '<' ;
GT : '>' ;
AND : '&' ;
Asterisco : '*' ;
Punto_Coma : ';' ;

WS: [ \n\r]+ ;