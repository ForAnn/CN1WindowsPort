// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.services {
public class TwitterRESTService: global::com.codename1.io.ConnectionRequest {

static TwitterRESTService() {
    // Value=statuses/user_timeline
    _fMETHOD_1USER_1TIMELINE = new global::java.lang.String();
    _fMETHOD_1USER_1TIMELINE.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101))}));
    // Value=search/tweets
    _fMETHOD_1TWEETS = new global::java.lang.String();
    _fMETHOD_1TWEETS.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 115))}));
}

private static global::java.lang.String _fauthToken;

private global::java.util.Hashtable _fparseTree;

public static global::java.lang.String _fMETHOD_1USER_1TIMELINE;

public static global::java.lang.String _fMETHOD_1TWEETS;

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    // Value=1.1
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)49)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49))}));
    _r1.i = 0;
    ((global::com.codename1.io.services.TwitterRESTService) _r2_o).@this((global::java.lang.String) _r3_o, (global::java.lang.String) _r0_o, 0!=_r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: void <init>(java.lang.String)]
}

public void @this(global::java.lang.String n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: void <init>(java.lang.String, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2 ? 1 : 0;
    // Value=1.1
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)49)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49))}));
    ((global::com.codename1.io.services.TwitterRESTService) _r1_o).@this((global::java.lang.String) _r2_o, (global::java.lang.String) _r0_o, 0!=_r3.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: void <init>(java.lang.String, boolean)]
}

public static global::System.Object initToken(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: java.lang.String initToken(java.lang.String, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = n1;
    _r6_o = n2;
    _r0_o = new global::com.codename1.io.services.TwitterRESTService_21();
    ((global::com.codename1.io.services.TwitterRESTService_21) _r0_o).@this();
    _r2.i = 1;
    ((global::com.codename1.io.ConnectionRequest) _r0_o).setPost(0!=_r2.i);
    // Value=https://api.twitter.com/oauth2/token
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110))}));
    ((global::com.codename1.io.ConnectionRequest) _r0_o).setUrl((global::java.lang.String) _r2_o);
    _r2_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r2_o).@this();
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r5_o);
    // Value=:
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r6_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    _r2_o = ((global::java.lang.String) _r2_o).getBytes();
    _r1_o = global::com.codename1.util.Base64.encodeNoNewline((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o);
    // Value=Authorization
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)65)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 122)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    // Value=Basic 
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)66)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 32))}));
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r1_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    ((global::com.codename1.io.ConnectionRequest) _r0_o).addRequestHeader((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o);
    // Value=application/x-www-form-urlencoded;charset=UTF-8
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 59)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    ((global::com.codename1.io.ConnectionRequest) _r0_o).setContentType((global::java.lang.String) _r2_o);
    // Value=grant_type
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)103)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    // Value=client_credentials
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 115))}));
    ((global::com.codename1.io.ConnectionRequest) _r0_o).addArgument((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o);
    _r2_o = global::com.codename1.io.NetworkManager.getInstance();
    ((global::com.codename1.io.NetworkManager) _r2_o).addToQueueAndWait((global::com.codename1.io.ConnectionRequest) _r0_o);
    _r2_o = global::com.codename1.io.services.TwitterRESTService._fauthToken;
    return (global::java.lang.String) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: java.lang.String initToken(java.lang.String, java.lang.String)]
}

public static void setToken(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: void setToken(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = n1;
    global::com.codename1.io.services.TwitterRESTService._fauthToken = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: void setToken(java.lang.String)]
}

public void @this(global::java.lang.String n1, global::java.lang.String n2, bool n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: void <init>(java.lang.String, java.lang.String, boolean)]
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
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r7.i = n3 ? 1 : 0;
    // Value=application/json
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 106)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::com.codename1.io.ConnectionRequest) _r4_o).@this();
    ((global::com.codename1.io.services.TwitterRESTService) _r4_o).setPost(0!=_r7.i);
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    // Value=https://api.twitter.com/
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 47))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r6_o);
    // Value=/
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r5_o);
    // Value=.json
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)46)), unchecked((char) unchecked((uint) 106)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::com.codename1.io.services.TwitterRESTService) _r4_o).setUrl((global::java.lang.String) _r0_o);
    // Value=Authorization
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)65)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 122)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r1_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r1_o).@this();
    // Value=Bearer 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)66)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32))}));
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r2_o = global::com.codename1.io.services.TwitterRESTService._fauthToken;
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::com.codename1.io.services.TwitterRESTService) _r4_o).addRequestHeader((global::java.lang.String) _r0_o, (global::java.lang.String) _r1_o);
    // Value=application/json
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 106)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::com.codename1.io.services.TwitterRESTService) _r4_o).setContentType((global::java.lang.String) _r3_o);
    // Value=Accept
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)65)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116))}));
    // Value=application/json
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 106)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::com.codename1.io.services.TwitterRESTService) _r4_o).addRequestHeader((global::java.lang.String) _r0_o, (global::java.lang.String) _r3_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: void <init>(java.lang.String, java.lang.String, boolean)]
}

public override void readResponse(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: void readResponse(java.io.InputStream)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = new global::java.io.InputStreamReader();
    // Value=UTF-8
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    ((global::java.io.InputStreamReader) _r0_o).@this((global::java.io.InputStream) _r4_o, (global::java.lang.String) _r1_o);
    _r1_o = new global::com.codename1.io.JSONParser();
    ((global::com.codename1.io.JSONParser) _r1_o).@this();
    _r1_o = ((global::com.codename1.io.JSONParser) _r1_o).parse((global::java.io.Reader) _r0_o);
    ((global::com.codename1.io.services.TwitterRESTService) _r3_o)._fparseTree = (global::java.util.Hashtable) _r1_o;
    _r1_o = new global::com.codename1.io.NetworkEvent();
    _r2_o = ((global::com.codename1.io.services.TwitterRESTService) _r3_o)._fparseTree;
    ((global::com.codename1.io.NetworkEvent) _r1_o).@this((global::com.codename1.io.ConnectionRequest) _r3_o, (global::java.lang.Object) _r2_o);
    ((global::com.codename1.io.services.TwitterRESTService) _r3_o).fireResponseListener((global::com.codename1.ui.events.ActionEvent) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: void readResponse(java.io.InputStream)]
}

public virtual global::System.Object getParseTree(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: java.util.Hashtable getParseTree()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.services.TwitterRESTService) _r1_o)._fparseTree;
    return (global::java.util.Hashtable) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: java.util.Hashtable getParseTree()]
}

public virtual int getStatusesCount(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: int getStatusesCount()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r1_o = ((global::com.codename1.io.services.TwitterRESTService) _r3_o)._fparseTree;
    // Value=statuses
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115))}));
    _r0_o = ((global::java.util.Hashtable) _r1_o).get((global::java.lang.Object) _r2_o);
    _r0_o = _r0_o;
    if (_r0_o != null) goto label14;
    _r1.i = 0;
    label13:;
    return _r1.i;
    label14:;
    _r1.i = ((global::java.util.Vector) _r0_o).size();
    goto label13;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: int getStatusesCount()]
}

public virtual global::System.Object getStatus(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: java.util.Hashtable getStatus(int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r4.i = n1;
    _r1_o = ((global::com.codename1.io.services.TwitterRESTService) _r3_o)._fparseTree;
    // Value=statuses
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115))}));
    _r0_o = ((global::java.util.Hashtable) _r1_o).get((global::java.lang.Object) _r2_o);
    _r0_o = _r0_o;
    _r3_o = ((global::java.util.Vector) _r0_o).get((int) _r4.i);
    _r3_o = _r3_o;
    return (global::java.util.Hashtable) _r3_o;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: java.util.Hashtable getStatus(int)]
}

public virtual global::System.Object getIdStr(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: java.lang.String getIdStr()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.i = ((global::com.codename1.io.services.TwitterRESTService) _r2_o).getStatusesCount();
    if (_r0.i <= 0) goto label21;
    _r0.i = 0;
    _r0_o = ((global::com.codename1.io.services.TwitterRESTService) _r2_o).getStatus((int) _r0.i);
    // Value=id_str
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114))}));
    _r2_o = ((global::java.util.Hashtable) _r0_o).get((global::java.lang.Object) _r1_o);
    _r2_o = _r2_o;
    _r0_o = _r2_o;
    label20:;
    return (global::java.lang.String) _r0_o;
    label21:;
    _r0_o = null;
    goto label20;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: java.lang.String getIdStr()]
}

public static global::System.Object access_2002(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: java.lang.String access$002(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = n1;
    global::com.codename1.io.services.TwitterRESTService._fauthToken = (global::java.lang.String) _r0_o;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: java.lang.String access$002(java.lang.String)]
}

public static global::System.Object access_2000(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService: java.lang.String access$000()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::com.codename1.io.services.TwitterRESTService._fauthToken;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService: java.lang.String access$000()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.TwitterRESTService]
//XMLVM_END_WRAPPER[com.codename1.io.services.TwitterRESTService]

} // end of class: TwitterRESTService

} // end of namespace: com.codename1.io.services
