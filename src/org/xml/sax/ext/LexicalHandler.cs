// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.xml.sax.ext {
public abstract class _iLexicalHandler {

} // end of abstract class: _iLexicalHandler

public interface LexicalHandler {
 void startDTD(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3);

 void endDTD();

 void startEntity(global::java.lang.String n1);

 void endEntity(global::java.lang.String n1);

 void startCDATA();

 void endCDATA();

 void comment(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3);

//XMLVM_BEGIN_WRAPPER[org.xml.sax.ext.LexicalHandler]
//XMLVM_END_WRAPPER[org.xml.sax.ext.LexicalHandler]

} // end of interface: LexicalHandler

} // end of namespace: org.xml.sax.ext
