// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.w3c.dom.events {
public class EventException: global::java.lang.RuntimeException {
public short _fcode;

public static short _fUNSPECIFIED_1EVENT_1TYPE_1ERR = 0;

public void @this(short n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.events.EventException: void <init>(short, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    _r2_o = n2;
    ((global::java.lang.RuntimeException) _r0_o).@this((global::java.lang.String) _r2_o);
    ((global::org.w3c.dom.events.EventException) _r0_o)._fcode = (short) _r1.i;
    return;
//XMLVM_END_WRAPPER[org.w3c.dom.events.EventException: void <init>(short, java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[org.w3c.dom.events.EventException]
//XMLVM_END_WRAPPER[org.w3c.dom.events.EventException]

} // end of class: EventException

} // end of namespace: org.w3c.dom.events
