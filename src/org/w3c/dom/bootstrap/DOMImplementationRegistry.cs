// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.w3c.dom.bootstrap {
public class DOMImplementationRegistry: global::java.lang.Object {

static DOMImplementationRegistry() {
    // Value=org.w3c.dom.DOMImplementationSourceList
    _fPROPERTY = new global::java.lang.String();
    _fPROPERTY.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 51)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
}

public static global::java.lang.String _fPROPERTY;


private global::java.util.Vector _fsources;

private void @this(global::java.util.Vector n1){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: void <init>(java.util.Vector)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::org.w3c.dom.bootstrap.DOMImplementationRegistry) _r0_o)._fsources = (global::java.util.Vector) _r1_o;
    return;
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: void <init>(java.util.Vector)]
}

public static global::System.Object newInstance(){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: org.w3c.dom.bootstrap.DOMImplementationRegistry newInstance()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r1_o).@this();
    _r0_o = new global::gnu.xml.dom.ImplementationSource();
    ((global::gnu.xml.dom.ImplementationSource) _r0_o).@this();
    ((global::java.util.Vector) _r1_o).addElement((global::java.lang.Object) _r0_o);
    _r2_o = new global::org.w3c.dom.bootstrap.DOMImplementationRegistry();
    ((global::org.w3c.dom.bootstrap.DOMImplementationRegistry) _r2_o).@this((global::java.util.Vector) _r1_o);
    return (global::org.w3c.dom.bootstrap.DOMImplementationRegistry) _r2_o;
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: org.w3c.dom.bootstrap.DOMImplementationRegistry newInstance()]
}

public virtual global::System.Object getDOMImplementation(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: org.w3c.dom.DOMImplementation getDOMImplementation(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r5_o = ((global::org.w3c.dom.bootstrap.DOMImplementationRegistry) _r6_o)._fsources;
    _r3.i = ((global::java.util.Vector) _r5_o).size();
    _r0.i = 0;
    label8:;
    if (_r0.i >= _r3.i) goto label29;
    _r5_o = ((global::org.w3c.dom.bootstrap.DOMImplementationRegistry) _r6_o)._fsources;
    _r4_o = ((global::java.util.Vector) _r5_o).elementAt((int) _r0.i);
    _r4_o = _r4_o;
    _r1_o = ((global::org.w3c.dom.DOMImplementationSource) _r4_o).getDOMImplementation((global::java.lang.String) _r7_o);
    if (_r1_o == null) goto label26;
    _r5_o = _r1_o;
    label25:;
    return (global::org.w3c.dom.DOMImplementation) _r5_o;
    label26:;
    _r0.i = _r0.i + 1;
    goto label8;
    label29:;
    _r5_o = null;
    goto label25;
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: org.w3c.dom.DOMImplementation getDOMImplementation(java.lang.String)]
}

public virtual global::System.Object getDOMImplementationList(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: org.w3c.dom.DOMImplementationList getDOMImplementationList(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    _r8_o = this;
    _r9_o = n1;
    _r2_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r2_o).@this();
    _r7_o = ((global::org.w3c.dom.bootstrap.DOMImplementationRegistry) _r8_o)._fsources;
    _r5.i = ((global::java.util.Vector) _r7_o).size();
    _r0.i = 0;
    label12:;
    if (_r0.i >= _r5.i) goto label46;
    _r7_o = ((global::org.w3c.dom.bootstrap.DOMImplementationRegistry) _r8_o)._fsources;
    _r6_o = ((global::java.util.Vector) _r7_o).elementAt((int) _r0.i);
    _r6_o = _r6_o;
    _r3_o = ((global::org.w3c.dom.DOMImplementationSource) _r6_o).getDOMImplementationList((global::java.lang.String) _r9_o);
    _r4.i = 0;
    label27:;
    _r7.i = ((global::org.w3c.dom.DOMImplementationList) _r3_o).getLength();
    if (_r4.i >= _r7.i) goto label43;
    _r1_o = ((global::org.w3c.dom.DOMImplementationList) _r3_o).item((int) _r4.i);
    ((global::java.util.Vector) _r2_o).addElement((global::java.lang.Object) _r1_o);
    _r4.i = _r4.i + 1;
    goto label27;
    label43:;
    _r0.i = _r0.i + 1;
    goto label12;
    label46:;
// Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$1 new-instance
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$1 new-instance");
// Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$1 <init>
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$1 <init>");
    return (global::org.w3c.dom.DOMImplementationList) _r7_o;
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: org.w3c.dom.DOMImplementationList getDOMImplementationList(java.lang.String)]
}

public virtual void addSource(global::org.w3c.dom.DOMImplementationSource n1){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: void addSource(org.w3c.dom.DOMImplementationSource)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    if (_r2_o != null) goto label8;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label8:;
    _r0_o = ((global::org.w3c.dom.bootstrap.DOMImplementationRegistry) _r1_o)._fsources;
    _r0.i = ((global::java.util.Vector) _r0_o).contains((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r0.i != 0) goto label21;
    _r0_o = ((global::org.w3c.dom.bootstrap.DOMImplementationRegistry) _r1_o)._fsources;
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r2_o);
    label21:;
    return;
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: void addSource(org.w3c.dom.DOMImplementationSource)]
}

private static global::System.Object getClassLoader(){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: java.lang.ClassLoader getClassLoader()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = global::org.xmlvm._nTIB.getClass(typeof(global::org.w3c.dom.bootstrap.DOMImplementationRegistry));
    try {
    _r0_o = global::org.w3c.dom.bootstrap.DOMImplementationRegistry.getContextClassLoader();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label10;
        }
        throw ex;
    } // end catch
    if (_r0_o == null) goto label18;
    _r2_o = _r0_o;
    label9:;
    return (global::java.lang.ClassLoader) _r2_o;
    label10:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::org.w3c.dom.bootstrap.DOMImplementationRegistry));
    _r2_o = ((global::java.lang.Class) _r3_o).getClassLoader();
    goto label9;
    label18:;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::org.w3c.dom.bootstrap.DOMImplementationRegistry));
    _r2_o = ((global::java.lang.Class) _r3_o).getClassLoader();
    goto label9;
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: java.lang.ClassLoader getClassLoader()]
}

private static global::System.Object getServiceValue(global::java.lang.ClassLoader n1){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: java.lang.String getServiceValue(java.lang.ClassLoader)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r9_o = n1;
    _r8_o = null;
    // Value=META-INF/services/org.w3c.dom.DOMImplementationSourceList
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 51)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    try {
    _r2_o = global::org.w3c.dom.bootstrap.DOMImplementationRegistry.getResourceAsStream((global::java.lang.ClassLoader) _r9_o, (global::java.lang.String) _r4_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label55;
        }
        throw ex;
    } // end catch
    if (_r2_o == null) goto label59;
    try {
    _r3_o = new global::java.io.BufferedReader();
    _r6_o = new global::java.io.InputStreamReader();
    // Value=UTF-8
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    ((global::java.io.InputStreamReader) _r6_o).@this((global::java.io.InputStream) _r2_o, (global::java.lang.String) _r7_o);
    _r7.i = 80;
    ((global::java.io.BufferedReader) _r3_o).@this((global::java.io.Reader) _r6_o, (int) _r7.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.UnsupportedEncodingException) {
            _ex = ex;
            goto label40;
        }
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label55;
        }
        throw ex;
    } // end catch
    label23:;
    try {
    _r5_o = ((global::java.io.BufferedReader) _r3_o).readLine();
    ((global::java.io.BufferedReader) _r3_o).close();
    if (_r5_o == null) goto label59;
    _r6.i = ((global::java.lang.String) _r5_o).length();
    if (_r6.i <= 0) goto label59;
    _r6_o = _r5_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label55;
        }
        throw ex;
    } // end catch
    label39:;
    try {
    return (global::java.lang.String) _r6_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label55;
        }
        throw ex;
    } // end catch
    label40:;
    try {
    _r6_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r6_o;
    _r3_o = new global::java.io.BufferedReader();
    _r6_o = new global::java.io.InputStreamReader();
    ((global::java.io.InputStreamReader) _r6_o).@this((global::java.io.InputStream) _r2_o);
    _r7.i = 80;
    ((global::java.io.BufferedReader) _r3_o).@this((global::java.io.Reader) _r6_o, (int) _r7.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label55;
        }
        throw ex;
    } // end catch
    goto label23;
    label55:;
    _r6_o = _ex.getJavaException();
    _ex = null;
    _r1_o = _r6_o;
    _r6_o = _r8_o;
    goto label39;
    label59:;
    _r6_o = _r8_o;
    goto label39;
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: java.lang.String getServiceValue(java.lang.ClassLoader)]
}

private static bool isJRE11(){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: boolean isJRE11()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    try {
    // Value=java.security.AccessController
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)106)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r0_o = global::java.lang.Class.forName((global::java.lang.String) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label8;
        }
        throw ex;
    } // end catch
    _r1.i = 0;
    label7:;
    return _r1.i!=0;
    label8:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    _r1.i = 1;
    goto label7;
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: boolean isJRE11()]
}

private static global::System.Object getContextClassLoader(){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: java.lang.ClassLoader getContextClassLoader()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0.i = global::org.w3c.dom.bootstrap.DOMImplementationRegistry.isJRE11() ? 1 : 0;
    if (_r0.i == 0) goto label8;
    _r0_o = null;
    label7:;
    return (global::java.lang.ClassLoader) _r0_o;
    label8:;
// Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$2 new-instance
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$2 new-instance");
// Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$2 <init>
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$2 <init>");
    _r0_o = global::java.security.AccessController.doPrivileged((global::java.security.PrivilegedAction) _r0_o);
    _r0_o = _r0_o;
    goto label7;
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: java.lang.ClassLoader getContextClassLoader()]
}

private static global::System.Object getSystemProperty(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: java.lang.String getSystemProperty(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.i = global::org.w3c.dom.bootstrap.DOMImplementationRegistry.isJRE11() ? 1 : 0;
    if (_r0.i == 0) goto label11;
    _r0_o = global::java.lang.System.getProperty((global::java.lang.String) _r1_o);
    label10:;
    return (global::java.lang.String) _r0_o;
    label11:;
// Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$3 new-instance
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$3 new-instance");
// Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$3 <init>
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$3 <init>");
    _r1_o = global::java.security.AccessController.doPrivileged((global::java.security.PrivilegedAction) _r0_o);
    _r1_o = _r1_o;
    _r0_o = _r1_o;
    goto label10;
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: java.lang.String getSystemProperty(java.lang.String)]
}

private static global::System.Object getResourceAsStream(global::java.lang.ClassLoader n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: java.io.InputStream getResourceAsStream(java.lang.ClassLoader, java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = n1;
    _r3_o = n2;
    _r1.i = global::org.w3c.dom.bootstrap.DOMImplementationRegistry.isJRE11() ? 1 : 0;
    if (_r1.i == 0) goto label19;
    if (_r2_o != null) goto label14;
    _r0_o = global::java.lang.ClassLoader.getSystemResourceAsStream((global::java.lang.String) _r3_o);
    label12:;
    _r1_o = _r0_o;
    label13:;
    return (global::java.io.InputStream) _r1_o;
    label14:;
    _r0_o = ((global::java.lang.ClassLoader) _r2_o).getResourceAsStream((global::java.lang.String) _r3_o);
    goto label12;
    label19:;
// Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$4 new-instance
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$4 new-instance");
// Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$4 <init>
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.w3c.dom.bootstrap.DOMImplementationRegistry$4 <init>");
    _r2_o = global::java.security.AccessController.doPrivileged((global::java.security.PrivilegedAction) _r1_o);
    _r2_o = _r2_o;
    _r1_o = _r2_o;
    goto label13;
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry: java.io.InputStream getResourceAsStream(java.lang.ClassLoader, java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry]
//XMLVM_END_WRAPPER[org.w3c.dom.bootstrap.DOMImplementationRegistry]

} // end of class: DOMImplementationRegistry

} // end of namespace: org.w3c.dom.bootstrap
