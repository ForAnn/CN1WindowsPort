// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.social {
public class GoogleConnect: global::com.codename1.social.Login {

static GoogleConnect() {
    @static();
}

private static global::java.lang.String _ftokenURL;

private static global::com.codename1.social.GoogleConnect _finstance;

public static global::java.lang.Class _fimplClass;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.GoogleConnect: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    ((global::com.codename1.social.Login) _r1_o).@this();
    // Value=https://accounts.google.com/o/oauth2/auth
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104))}));
    ((global::com.codename1.social.GoogleConnect) _r1_o).setOauth2URL((global::java.lang.String) _r0_o);
    // Value=profile email
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108))}));
    ((global::com.codename1.social.GoogleConnect) _r1_o).setScope((global::java.lang.String) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.social.GoogleConnect: void <init>()]
}

public static global::System.Object getInstance(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.GoogleConnect: com.codename1.social.GoogleConnect getInstance()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = global::com.codename1.social.GoogleConnect._finstance;
    if (_r1_o != null) goto label18;
    _r1_o = global::com.codename1.social.GoogleConnect._fimplClass;
    if (_r1_o == null) goto label31;
    try {
    _r1_o = global::com.codename1.social.GoogleConnect._fimplClass;
    _r0_o = ((global::java.lang.Class) _r1_o).newInstance();
    _r0_o = _r0_o;
    global::com.codename1.social.GoogleConnect._finstance = (global::com.codename1.social.GoogleConnect) _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label21;
        }
        throw ex;
    } // end catch
    label18:;
    _r1_o = global::com.codename1.social.GoogleConnect._finstance;
    return (global::com.codename1.social.GoogleConnect) _r1_o;
    label21:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r1_o;
    _r1_o = new global::com.codename1.social.GoogleConnect();
    ((global::com.codename1.social.GoogleConnect) _r1_o).@this();
    global::com.codename1.social.GoogleConnect._finstance = (global::com.codename1.social.GoogleConnect) _r1_o;
    goto label18;
    label31:;
    _r1_o = new global::com.codename1.social.GoogleConnect();
    ((global::com.codename1.social.GoogleConnect) _r1_o).@this();
    global::com.codename1.social.GoogleConnect._finstance = (global::com.codename1.social.GoogleConnect) _r1_o;
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.social.GoogleConnect: com.codename1.social.GoogleConnect getInstance()]
}

public override bool isNativeLoginSupported(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.GoogleConnect: boolean isNativeLoginSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.social.GoogleConnect: boolean isNativeLoginSupported()]
}

public override global::System.Object createOauth2(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.GoogleConnect: com.codename1.io.Oauth2 createOauth2()]
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
    _r8_o = this;
    _r7_o = new global::java.util.Hashtable();
    ((global::java.util.Hashtable) _r7_o).@this();
    // Value=approval_prompt
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116))}));
    // Value=force
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101))}));
    ((global::java.util.Hashtable) _r7_o).put((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r2_o);
    // Value=access_type
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    // Value=offline
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)111)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101))}));
    ((global::java.util.Hashtable) _r7_o).put((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r2_o);
    _r0_o = new global::com.codename1.io.Oauth2();
    _r1_o = ((global::com.codename1.social.GoogleConnect) _r8_o)._foauth2URL;
    _r2_o = ((global::com.codename1.social.GoogleConnect) _r8_o)._fclientId;
    _r3_o = ((global::com.codename1.social.GoogleConnect) _r8_o)._fredirectURI;
    _r4_o = ((global::com.codename1.social.GoogleConnect) _r8_o)._fscope;
    _r5_o = global::com.codename1.social.GoogleConnect._ftokenURL;
    _r6_o = ((global::com.codename1.social.GoogleConnect) _r8_o)._fclientSecret;
    ((global::com.codename1.io.Oauth2) _r0_o).@this((global::java.lang.String) _r1_o, (global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o, (global::java.util.Hashtable) _r7_o);
    return (global::com.codename1.io.Oauth2) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.social.GoogleConnect: com.codename1.io.Oauth2 createOauth2()]
}

public override bool validateToken(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.GoogleConnect: boolean validateToken(java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r2.i = 1;
    _r5.i = 0;
    _r1_o = new global::org.xmlvm._nArrayAdapter<bool>(new bool[_r2.i]);
    ((global::org.xmlvm._nArrayAdapter<bool>) _r1_o)[_r5.i] = 0!=_r2.i;
    _r0_o = new global::com.codename1.social.GoogleConnect_21();
    ((global::com.codename1.social.GoogleConnect_21) _r0_o).@this((global::com.codename1.social.GoogleConnect) _r6_o, (global::org.xmlvm._nArrayAdapter<bool>) _r1_o);
    ((global::com.codename1.io.ConnectionRequest) _r0_o).setPost(0!=_r5.i);
    // Value=https://www.googleapis.com/plus/v1/people/me
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.io.ConnectionRequest) _r0_o).setUrl((global::java.lang.String) _r2_o);
    // Value=Authorization
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)65)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 122)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    // Value=Bearer 
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)66)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32))}));
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r7_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    ((global::com.codename1.io.ConnectionRequest) _r0_o).addRequestHeader((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o);
    _r2_o = global::com.codename1.io.NetworkManager.getInstance();
    ((global::com.codename1.io.NetworkManager) _r2_o).addToQueueAndWait((global::com.codename1.io.ConnectionRequest) _r0_o);
    _r2.i = ((global::org.xmlvm._nArrayAdapter<bool>) _r1_o)[_r5.i] ? 1 : 0;
    return _r2.i!=0;
//XMLVM_END_WRAPPER[com.codename1.social.GoogleConnect: boolean validateToken(java.lang.String)]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.GoogleConnect: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    // Value=https://www.googleapis.com/oauth2/v3/token
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 51)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110))}));
    global::com.codename1.social.GoogleConnect._ftokenURL = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.social.GoogleConnect: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.social.GoogleConnect]
//XMLVM_END_WRAPPER[com.codename1.social.GoogleConnect]

} // end of class: GoogleConnect

} // end of namespace: com.codename1.social