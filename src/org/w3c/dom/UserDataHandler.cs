// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.w3c.dom {
public abstract class _iUserDataHandler {
public static short _fNODE_1CLONED = 1;

public static short _fNODE_1IMPORTED = 2;

public static short _fNODE_1DELETED = 3;

public static short _fNODE_1RENAMED = 4;

public static short _fNODE_1ADOPTED = 5;


} // end of abstract class: _iUserDataHandler

public interface UserDataHandler {
 void handle(short n1, global::java.lang.String n2, global::java.lang.Object n3, global::org.w3c.dom.Node n4, global::org.w3c.dom.Node n5);

//XMLVM_BEGIN_WRAPPER[org.w3c.dom.UserDataHandler]
//XMLVM_END_WRAPPER[org.w3c.dom.UserDataHandler]

} // end of interface: UserDataHandler

} // end of namespace: org.w3c.dom
