// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.security {
public abstract class BasicPermission: global::java.security.Permission,global::java.io.Serializable {

new public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.security.BasicPermission: void <init>(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.security.Permission) _r0_o).@this((global::java.lang.String) _r1_o);
    ((global::java.security.BasicPermission) _r0_o).checkName((global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.security.BasicPermission: void <init>(java.lang.String)]
}

public void @this(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[java.security.BasicPermission: void <init>(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.security.Permission) _r0_o).@this((global::java.lang.String) _r1_o);
    ((global::java.security.BasicPermission) _r0_o).checkName((global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.security.BasicPermission: void <init>(java.lang.String, java.lang.String)]
}

private void checkName(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.security.BasicPermission: void checkName(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    if (_r3_o != null) goto label14;
    _r0_o = new global::java.lang.NullPointerException();
    // Value=security.28
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 56))}));
// Red class access removed: org.apache.harmony.security.internal.nls.Messages getString
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.apache.harmony.security.internal.nls.Messages getString");
    ((global::java.lang.NullPointerException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label14:;
    _r0.i = ((global::java.lang.String) _r3_o).length();
    if (_r0.i != 0) goto label32;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=security.29
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 57))}));
// Red class access removed: org.apache.harmony.security.internal.nls.Messages getString
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.apache.harmony.security.internal.nls.Messages getString");
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label32:;
    return;
//XMLVM_END_WRAPPER[java.security.BasicPermission: void checkName(java.lang.String)]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.security.BasicPermission: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    if (_r3_o != _r2_o) goto label4;
    _r0.i = 1;
    label3:;
    return _r0.i!=0;
    label4:;
    if (_r3_o == null) goto label31;
    _r0_o = ((global::java.lang.Object) _r3_o).getClass();
    _r1_o = ((global::java.lang.Object) _r2_o).getClass();
    if (_r0_o != _r1_o) goto label31;
    _r0_o = ((global::java.security.BasicPermission) _r2_o).getName();
    _r1_o = ((global::java.security.Permission) _r3_o).getName();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    goto label3;
    label31:;
    _r0.i = 0;
    goto label3;
//XMLVM_END_WRAPPER[java.security.BasicPermission: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.security.BasicPermission: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.security.BasicPermission) _r1_o).getName();
    _r0.i = ((global::java.lang.String) _r0_o).hashCode();
    return _r0.i;
//XMLVM_END_WRAPPER[java.security.BasicPermission: int hashCode()]
}

public override global::System.Object getActions(){
//XMLVM_BEGIN_WRAPPER[java.security.BasicPermission: java.lang.String getActions()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.security.BasicPermission: java.lang.String getActions()]
}

public override bool implies(global::java.security.Permission n1){
//XMLVM_BEGIN_WRAPPER[java.security.BasicPermission: boolean implies(java.security.Permission)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    // Value=exitVM.*
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 86)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 42))}));
    // Value=exitVM
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 86)), unchecked((char) unchecked((uint) 77))}));
    if (_r7_o == null) goto label56;
    _r0_o = ((global::java.lang.Object) _r7_o).getClass();
    _r1_o = ((global::java.lang.Object) _r6_o).getClass();
    if (_r0_o != _r1_o) goto label56;
    _r0_o = ((global::java.security.BasicPermission) _r6_o).getName();
    _r1_o = ((global::java.security.Permission) _r7_o).getName();
    _r2.i = ((_r6_o != null) && (_r6_o is global::java.lang.RuntimePermission)) ? 1 : 0;
    if (_r2.i == 0) goto label58;
    // Value=exitVM
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 86)), unchecked((char) unchecked((uint) 77))}));
    _r2.i = ((global::java.lang.String) _r1_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r2.i == 0) goto label39;
    // Value=exitVM.*
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 86)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 42))}));
    _r1_o = _r4_o;
    label39:;
    // Value=exitVM
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 86)), unchecked((char) unchecked((uint) 77))}));
    _r2.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r2.i == 0) goto label58;
    // Value=exitVM.*
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 86)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 42))}));
    _r0_o = _r1_o;
    _r1_o = _r4_o;
    label51:;
    _r0.i = global::java.security.BasicPermission.nameImplies((global::java.lang.String) _r1_o, (global::java.lang.String) _r0_o) ? 1 : 0;
    label55:;
    return _r0.i!=0;
    label56:;
    _r0.i = 0;
    goto label55;
    label58:;
    _r5_o = _r1_o;
    _r1_o = _r0_o;
    _r0_o = _r5_o;
    goto label51;
//XMLVM_END_WRAPPER[java.security.BasicPermission: boolean implies(java.security.Permission)]
}

public static bool nameImplies(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[java.security.BasicPermission: boolean nameImplies(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r5_o = n1;
    _r6_o = n2;
    _r4.i = 0;
    _r3.i = 1;
    if (_r5_o != _r6_o) goto label6;
    _r0.i = _r3.i;
    label5:;
    return _r0.i!=0;
    label6:;
    _r0.i = ((global::java.lang.String) _r5_o).length();
    _r1.i = ((global::java.lang.String) _r6_o).length();
    if (_r0.i <= _r1.i) goto label18;
    _r0.i = _r4.i;
    goto label5;
    label18:;
    _r0.i = _r0.i + -1;
    _r1.i = ((global::java.lang.String) _r5_o).charAt((int) _r0.i);
    _r2.i = 42;
    if (_r1.i != _r2.i) goto label46;
    if (_r0.i == 0) goto label40;
    _r1.i = _r0.i - _r3.i;
    _r1.i = ((global::java.lang.String) _r5_o).charAt((int) _r1.i);
    _r2.i = 46;
    if (_r1.i != _r2.i) goto label46;
    label40:;
    _r0.i = _r0.i + -1;
    label42:;
    if (_r0.i >= 0) goto label55;
    _r0.i = _r3.i;
    goto label5;
    label46:;
    _r1.i = ((global::java.lang.String) _r6_o).length();
    _r1.i = _r1.i - _r3.i;
    if (_r0.i == _r1.i) goto label42;
    _r0.i = _r4.i;
    goto label5;
    label55:;
    _r1.i = ((global::java.lang.String) _r5_o).charAt((int) _r0.i);
    _r2.i = ((global::java.lang.String) _r6_o).charAt((int) _r0.i);
    if (_r1.i == _r2.i) goto label67;
    _r0.i = _r4.i;
    goto label5;
    label67:;
    _r0.i = _r0.i + -1;
    goto label42;
//XMLVM_END_WRAPPER[java.security.BasicPermission: boolean nameImplies(java.lang.String, java.lang.String)]
}

public override global::System.Object newPermissionCollection(){
//XMLVM_BEGIN_WRAPPER[java.security.BasicPermission: java.security.PermissionCollection newPermissionCollection()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
// Red class access removed: java.security.BasicPermissionCollection new-instance
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.security.BasicPermissionCollection new-instance");
// Red class access removed: java.security.BasicPermissionCollection <init>
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.security.BasicPermissionCollection <init>");
    return (global::java.security.PermissionCollection) _r0_o;
//XMLVM_END_WRAPPER[java.security.BasicPermission: java.security.PermissionCollection newPermissionCollection()]
}

private void readObject(global::java.io.ObjectInputStream n1){
//XMLVM_BEGIN_WRAPPER[java.security.BasicPermission: void readObject(java.io.ObjectInputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.io.ObjectInputStream) _r2_o).defaultReadObject();
    _r0_o = ((global::java.security.BasicPermission) _r1_o).getName();
    ((global::java.security.BasicPermission) _r1_o).checkName((global::java.lang.String) _r0_o);
    return;
//XMLVM_END_WRAPPER[java.security.BasicPermission: void readObject(java.io.ObjectInputStream)]
}

//XMLVM_BEGIN_WRAPPER[java.security.BasicPermission]
//XMLVM_END_WRAPPER[java.security.BasicPermission]

} // end of class: BasicPermission

} // end of namespace: java.security
