// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.cloud {
public class CloudPersona: global::java.lang.Object {
private global::java.lang.String _fpersona;

private static global::com.codename1.cloud.CloudPersona _finstance;

private void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudPersona: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudPersona: void <init>()]
}

public static global::System.Object getCurrentPersona(){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudPersona: com.codename1.cloud.CloudPersona getCurrentPersona()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::com.codename1.cloud.CloudPersona._finstance;
    if (_r0_o != null) goto label22;
    _r0_o = new global::com.codename1.cloud.CloudPersona();
    ((global::com.codename1.cloud.CloudPersona) _r0_o).@this();
    global::com.codename1.cloud.CloudPersona._finstance = (global::com.codename1.cloud.CloudPersona) _r0_o;
    _r0_o = global::com.codename1.cloud.CloudPersona._finstance;
    // Value=CN1Persona
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97))}));
    _r2_o = null;
    _r1_o = global::com.codename1.io.Preferences.get((global::java.lang.String) _r1_o, (global::java.lang.String) _r2_o);
    ((global::com.codename1.cloud.CloudPersona) _r0_o)._fpersona = (global::java.lang.String) _r1_o;
    label22:;
    _r0_o = global::com.codename1.cloud.CloudPersona._finstance;
    return (global::com.codename1.cloud.CloudPersona) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudPersona: com.codename1.cloud.CloudPersona getCurrentPersona()]
}

public virtual global::System.Object getToken(){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudPersona: java.lang.String getToken()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.cloud.CloudPersona) _r1_o)._fpersona;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudPersona: java.lang.String getToken()]
}

public static void createFromToken(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudPersona: void createFromToken(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r0_o = global::com.codename1.cloud.CloudPersona._finstance;
    if (_r0_o != null) goto label11;
    _r0_o = new global::com.codename1.cloud.CloudPersona();
    ((global::com.codename1.cloud.CloudPersona) _r0_o).@this();
    global::com.codename1.cloud.CloudPersona._finstance = (global::com.codename1.cloud.CloudPersona) _r0_o;
    label11:;
    _r0_o = global::com.codename1.cloud.CloudPersona._finstance;
    ((global::com.codename1.cloud.CloudPersona) _r0_o)._fpersona = (global::java.lang.String) _r1_o;
    // Value=CN1Persona
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97))}));
    global::com.codename1.io.Preferences.set((global::java.lang.String) _r0_o, (global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudPersona: void createFromToken(java.lang.String)]
}

public static bool createAnonymous(){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudPersona: boolean createAnonymous()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = null;
    _r7.i = 1;
    _r4_o = global::com.codename1.cloud.CloudPersona._finstance;
    if (_r4_o != null) goto label9;
    global::com.codename1.cloud.CloudPersona.getCurrentPersona();
    label9:;
    _r3_o = new global::com.codename1.io.ConnectionRequest();
    ((global::com.codename1.io.ConnectionRequest) _r3_o).@this();
    ((global::com.codename1.io.ConnectionRequest) _r3_o).setPost(0!=_r7.i);
    // Value=https://codename-one.appspot.com/objStoreUser
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 106)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::com.codename1.io.ConnectionRequest) _r3_o).setUrl((global::java.lang.String) _r4_o);
    // Value=pk
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 107))}));
    _r5_o = global::com.codename1.ui.Display.getInstance();
    // Value=package_name
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    _r5_o = ((global::com.codename1.ui.Display) _r5_o).getProperty((global::java.lang.String) _r6_o, (global::java.lang.String) _r8_o);
    ((global::com.codename1.io.ConnectionRequest) _r3_o).addArgument((global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    // Value=bb
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)98)), unchecked((char) unchecked((uint) 98))}));
    _r5_o = global::com.codename1.ui.Display.getInstance();
    // Value=built_by_user
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)98)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r5_o = ((global::com.codename1.ui.Display) _r5_o).getProperty((global::java.lang.String) _r6_o, (global::java.lang.String) _r8_o);
    ((global::com.codename1.io.ConnectionRequest) _r3_o).addArgument((global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    _r4_o = global::com.codename1.io.NetworkManager.getInstance();
    ((global::com.codename1.io.NetworkManager) _r4_o).addToQueueAndWait((global::com.codename1.io.ConnectionRequest) _r3_o);
    _r4.i = ((global::com.codename1.io.ConnectionRequest) _r3_o).getResposeCode();
    _r5.i = 200;
    if (_r4.i == _r5.i) goto label69;
    _r4.i = 0;
    label68:;
    return _r4.i!=0;
    label69:;
    _r0_o = new global::java.io.ByteArrayInputStream();
    _r4_o = ((global::com.codename1.io.ConnectionRequest) _r3_o).getResponseData();
    ((global::java.io.ByteArrayInputStream) _r0_o).@this((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o);
    _r1_o = new global::java.io.DataInputStream();
    ((global::java.io.DataInputStream) _r1_o).@this((global::java.io.InputStream) _r0_o);
    _r4_o = global::com.codename1.cloud.CloudPersona._finstance;
    if (_r4_o != null) goto label94;
    _r4_o = new global::com.codename1.cloud.CloudPersona();
    ((global::com.codename1.cloud.CloudPersona) _r4_o).@this();
    global::com.codename1.cloud.CloudPersona._finstance = (global::com.codename1.cloud.CloudPersona) _r4_o;
    label94:;
    try {
    _r4_o = global::com.codename1.cloud.CloudPersona._finstance;
    _r5_o = ((global::java.io.DataInputStream) _r1_o).readUTF();
    ((global::com.codename1.cloud.CloudPersona) _r4_o)._fpersona = (global::java.lang.String) _r5_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label121;
        }
        throw ex;
    } // end catch
    label102:;
    // Value=CN1Persona
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97))}));
    _r5_o = global::com.codename1.cloud.CloudPersona._finstance;
    _r5_o = ((global::com.codename1.cloud.CloudPersona) _r5_o)._fpersona;
    global::com.codename1.io.Preferences.set((global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    // Value=CN1PersonaAnonymous
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115))}));
    global::com.codename1.io.Preferences.set((global::java.lang.String) _r4_o, 0!=_r7.i);
    global::com.codename1.io.Util.cleanup((global::java.lang.Object) _r1_o);
    _r4.i = _r7.i;
    goto label68;
    label121:;
    _r4_o = _ex.getJavaException();
    _ex = null;
    _r2_o = _r4_o;
    ((global::java.io.IOException) _r2_o).printStackTrace();
    goto label102;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudPersona: boolean createAnonymous()]
}

public static bool createOrLogin(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudPersona: boolean createOrLogin(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r10_o = n1;
    _r11_o = n2;
    _r9_o = null;
    _r8.i = 0;
    _r7.i = 1;
    _r4_o = global::com.codename1.cloud.CloudPersona._finstance;
    if (_r4_o != null) goto label18;
    global::com.codename1.cloud.CloudPersona.getCurrentPersona();
    _r4_o = global::com.codename1.cloud.CloudPersona._finstance;
    _r4_o = ((global::com.codename1.cloud.CloudPersona) _r4_o)._fpersona;
    if (_r4_o == null) goto label18;
    _r4.i = _r7.i;
    label17:;
    return _r4.i!=0;
    label18:;
    _r3_o = new global::com.codename1.io.ConnectionRequest();
    ((global::com.codename1.io.ConnectionRequest) _r3_o).@this();
    ((global::com.codename1.io.ConnectionRequest) _r3_o).setPost(0!=_r7.i);
    // Value=https://codename-one.appspot.com/objStoreUser
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 106)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::com.codename1.io.ConnectionRequest) _r3_o).setUrl((global::java.lang.String) _r4_o);
    // Value=l
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108))}));
    ((global::com.codename1.io.ConnectionRequest) _r3_o).addArgument((global::java.lang.String) _r4_o, (global::java.lang.String) _r10_o);
    // Value=p
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112))}));
    ((global::com.codename1.io.ConnectionRequest) _r3_o).addArgument((global::java.lang.String) _r4_o, (global::java.lang.String) _r11_o);
    // Value=pk
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 107))}));
    _r5_o = global::com.codename1.ui.Display.getInstance();
    // Value=package_name
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    _r5_o = ((global::com.codename1.ui.Display) _r5_o).getProperty((global::java.lang.String) _r6_o, (global::java.lang.String) _r9_o);
    ((global::com.codename1.io.ConnectionRequest) _r3_o).addArgument((global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    // Value=bb
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)98)), unchecked((char) unchecked((uint) 98))}));
    _r5_o = global::com.codename1.ui.Display.getInstance();
    // Value=built_by_user
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)98)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r5_o = ((global::com.codename1.ui.Display) _r5_o).getProperty((global::java.lang.String) _r6_o, (global::java.lang.String) _r9_o);
    ((global::com.codename1.io.ConnectionRequest) _r3_o).addArgument((global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    _r4_o = global::com.codename1.io.NetworkManager.getInstance();
    ((global::com.codename1.io.NetworkManager) _r4_o).addToQueueAndWait((global::com.codename1.io.ConnectionRequest) _r3_o);
    _r4.i = ((global::com.codename1.io.ConnectionRequest) _r3_o).getResposeCode();
    _r5.i = 200;
    if (_r4.i == _r5.i) goto label88;
    _r4.i = _r8.i;
    goto label17;
    label88:;
    _r0_o = new global::java.io.ByteArrayInputStream();
    _r4_o = ((global::com.codename1.io.ConnectionRequest) _r3_o).getResponseData();
    ((global::java.io.ByteArrayInputStream) _r0_o).@this((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o);
    _r1_o = new global::java.io.DataInputStream();
    ((global::java.io.DataInputStream) _r1_o).@this((global::java.io.InputStream) _r0_o);
    try {
    _r4.i = ((global::java.io.DataInputStream) _r1_o).readBoolean() ? 1 : 0;
    if (_r4.i == 0) goto label141;
    _r4_o = global::com.codename1.cloud.CloudPersona._finstance;
    if (_r4_o != null) goto label119;
    _r4_o = new global::com.codename1.cloud.CloudPersona();
    ((global::com.codename1.cloud.CloudPersona) _r4_o).@this();
    global::com.codename1.cloud.CloudPersona._finstance = (global::com.codename1.cloud.CloudPersona) _r4_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label146;
        }
        throw ex;
    } // end catch
    label119:;
    try {
    _r4_o = global::com.codename1.cloud.CloudPersona._finstance;
    _r5_o = ((global::java.io.DataInputStream) _r1_o).readUTF();
    ((global::com.codename1.cloud.CloudPersona) _r4_o)._fpersona = (global::java.lang.String) _r5_o;
    // Value=CN1Persona
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97))}));
    _r5_o = global::com.codename1.cloud.CloudPersona._finstance;
    _r5_o = ((global::com.codename1.cloud.CloudPersona) _r5_o)._fpersona;
    global::com.codename1.io.Preferences.set((global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    global::com.codename1.io.Util.cleanup((global::java.lang.Object) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label146;
        }
        throw ex;
    } // end catch
    label139:;
    try {
    _r4.i = _r7.i;
    goto label17;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label146;
        }
        throw ex;
    } // end catch
    label141:;
    try {
    global::com.codename1.io.Util.cleanup((global::java.lang.Object) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label146;
        }
        throw ex;
    } // end catch
    _r4.i = _r8.i;
    goto label17;
    label146:;
    _r4_o = _ex.getJavaException();
    _ex = null;
    _r2_o = _r4_o;
    ((global::java.io.IOException) _r2_o).printStackTrace();
    goto label139;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudPersona: boolean createOrLogin(java.lang.String, java.lang.String)]
}

public virtual void logout(){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudPersona: void logout()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    // Value=CN1PersonaAnonymous
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115))}));
    _r1.i = 0;
    _r0.i = global::com.codename1.io.Preferences.get((global::java.lang.String) _r0_o, 0!=_r1.i) ? 1 : 0;
    if (_r0.i == 0) goto label17;
    _r0_o = new global::java.lang.RuntimeException();
    // Value=Anonymous personas can't be logged out!
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)65)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 39)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 33))}));
    ((global::java.lang.RuntimeException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r0_o);
    label17:;
    // Value=CN1Persona
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97))}));
    global::com.codename1.io.Preferences.delete((global::java.lang.String) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudPersona: void logout()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudPersona]
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudPersona]

} // end of class: CloudPersona

} // end of namespace: com.codename1.cloud
