// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.w3c.dom {
public abstract class _iTypeInfo {
public static int _fDERIVATION_1RESTRICTION = 1;

public static int _fDERIVATION_1EXTENSION = 2;

public static int _fDERIVATION_1UNION = 4;

public static int _fDERIVATION_1LIST = 8;


} // end of abstract class: _iTypeInfo

public interface TypeInfo {
 global::System.Object getTypeName();

 global::System.Object getTypeNamespace();

 bool isDerivedFrom(global::java.lang.String n1, global::java.lang.String n2, int n3);

//XMLVM_BEGIN_WRAPPER[org.w3c.dom.TypeInfo]
//XMLVM_END_WRAPPER[org.w3c.dom.TypeInfo]

} // end of interface: TypeInfo

} // end of namespace: org.w3c.dom
