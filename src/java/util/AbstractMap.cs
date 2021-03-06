// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public abstract class AbstractMap: global::java.lang.Object,global::java.util.Map {
public global::java.util.Set _fkeySet;

public global::java.util.Collection _fvaluesCollection;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.AbstractMap: void <init>()]
}

public virtual void clear(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: void clear()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.AbstractMap) _r1_o).entrySet();
    ((global::java.util.Set) _r0_o).clear();
    return;
//XMLVM_END_WRAPPER[java.util.AbstractMap: void clear()]
}

public virtual bool containsKey(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: boolean containsKey(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 1;
    _r0_o = ((global::java.util.AbstractMap) _r3_o).entrySet();
    _r0_o = ((global::java.util.Set) _r0_o).iterator();
    if (_r4_o == null) goto label51;
    label11:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label19;
    label17:;
    _r0.i = 0;
    label18:;
    return _r0.i!=0;
    label19:;
    _r3_o = ((global::java.util.Iterator) _r0_o).next();
    _r1_o = ((global::java.util.Map_2Entry) _r3_o).getKey();
    _r1.i = ((global::java.lang.Object) _r4_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label11;
    _r0.i = _r2.i;
    goto label18;
    label37:;
    _r3_o = ((global::java.util.Iterator) _r0_o).next();
    _r1_o = ((global::java.util.Map_2Entry) _r3_o).getKey();
    if (_r1_o != null) goto label51;
    _r0.i = _r2.i;
    goto label18;
    label51:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label37;
    goto label17;
//XMLVM_END_WRAPPER[java.util.AbstractMap: boolean containsKey(java.lang.Object)]
}

public virtual bool containsValue(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: boolean containsValue(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 1;
    _r0_o = ((global::java.util.AbstractMap) _r3_o).entrySet();
    _r0_o = ((global::java.util.Set) _r0_o).iterator();
    if (_r4_o == null) goto label51;
    label11:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label19;
    label17:;
    _r0.i = 0;
    label18:;
    return _r0.i!=0;
    label19:;
    _r3_o = ((global::java.util.Iterator) _r0_o).next();
    _r1_o = ((global::java.util.Map_2Entry) _r3_o).getValue();
    _r1.i = ((global::java.lang.Object) _r4_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label11;
    _r0.i = _r2.i;
    goto label18;
    label37:;
    _r3_o = ((global::java.util.Iterator) _r0_o).next();
    _r1_o = ((global::java.util.Map_2Entry) _r3_o).getValue();
    if (_r1_o != null) goto label51;
    _r0.i = _r2.i;
    goto label18;
    label51:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label37;
    goto label17;
//XMLVM_END_WRAPPER[java.util.AbstractMap: boolean containsValue(java.lang.Object)]
}

public abstract global::System.Object entrySet();

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r5.i = 1;
    _r4.i = 0;
    if (_r6_o != _r7_o) goto label6;
    _r0.i = _r5.i;
    label5:;
    return _r0.i!=0;
    label6:;
    _r0.i = ((_r7_o != null) && (_r7_o is global::java.util.Map)) ? 1 : 0;
    if (_r0.i == 0) goto label84;
    _r0.i = ((global::java.util.AbstractMap) _r6_o).size();
    _r1.i = ((global::java.util.Map) _r7_o).size();
    if (_r0.i == _r1.i) goto label24;
    _r0.i = _r4.i;
    goto label5;
    label24:;
    try {
    _r0_o = ((global::java.util.AbstractMap) _r6_o).entrySet();
    _r0_o = ((global::java.util.Set) _r0_o).iterator();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NullPointerException) {
            _ex = ex;
            goto label78;
        }
        if (_java_exception is global::java.lang.ClassCastException) {
            _ex = ex;
            goto label81;
        }
        throw ex;
    } // end catch
    label32:;
    try {
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label40;
    _r0.i = _r5.i;
    goto label5;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NullPointerException) {
            _ex = ex;
            goto label78;
        }
        if (_java_exception is global::java.lang.ClassCastException) {
            _ex = ex;
            goto label81;
        }
        throw ex;
    } // end catch
    label40:;
    try {
    _r6_o = ((global::java.util.Iterator) _r0_o).next();
    _r1_o = ((global::java.util.Map_2Entry) _r6_o).getKey();
    _r2_o = ((global::java.util.Map_2Entry) _r6_o).getValue();
    _r3_o = ((global::java.util.Map) _r7_o).get((global::java.lang.Object) _r1_o);
    if (_r2_o != null) goto label70;
    if (_r3_o != null) goto label68;
    _r1.i = ((global::java.util.Map) _r7_o).containsKey((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i != 0) goto label32;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NullPointerException) {
            _ex = ex;
            goto label78;
        }
        if (_java_exception is global::java.lang.ClassCastException) {
            _ex = ex;
            goto label81;
        }
        throw ex;
    } // end catch
    label68:;
    try {
    _r0.i = _r4.i;
    goto label5;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NullPointerException) {
            _ex = ex;
            goto label78;
        }
        if (_java_exception is global::java.lang.ClassCastException) {
            _ex = ex;
            goto label81;
        }
        throw ex;
    } // end catch
    label70:;
    try {
    _r1.i = ((global::java.lang.Object) _r2_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NullPointerException) {
            _ex = ex;
            goto label78;
        }
        if (_java_exception is global::java.lang.ClassCastException) {
            _ex = ex;
            goto label81;
        }
        throw ex;
    } // end catch
    if (_r1.i != 0) goto label32;
    _r0.i = _r4.i;
    goto label5;
    label78:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0.i = _r4.i;
    goto label5;
    label81:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0.i = _r4.i;
    goto label5;
    label84:;
    _r0.i = _r4.i;
    goto label5;
//XMLVM_END_WRAPPER[java.util.AbstractMap: boolean equals(java.lang.Object)]
}

public virtual global::System.Object get(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: java.lang.Object get(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::java.util.AbstractMap) _r2_o).entrySet();
    _r0_o = ((global::java.util.Set) _r0_o).iterator();
    if (_r3_o == null) goto label56;
    label10:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label18;
    label16:;
    _r0_o = null;
    label17:;
    return (global::java.lang.Object) _r0_o;
    label18:;
    _r2_o = ((global::java.util.Iterator) _r0_o).next();
    _r1_o = ((global::java.util.Map_2Entry) _r2_o).getKey();
    _r1.i = ((global::java.lang.Object) _r3_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label10;
    _r0_o = ((global::java.util.Map_2Entry) _r2_o).getValue();
    goto label17;
    label39:;
    _r2_o = ((global::java.util.Iterator) _r0_o).next();
    _r1_o = ((global::java.util.Map_2Entry) _r2_o).getKey();
    if (_r1_o != null) goto label56;
    _r0_o = ((global::java.util.Map_2Entry) _r2_o).getValue();
    goto label17;
    label56:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label39;
    goto label16;
//XMLVM_END_WRAPPER[java.util.AbstractMap: java.lang.Object get(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = 0;
    _r1_o = ((global::java.util.AbstractMap) _r3_o).entrySet();
    _r1_o = ((global::java.util.Set) _r1_o).iterator();
    label9:;
    _r2.i = ((global::java.util.Iterator) _r1_o).hasNext() ? 1 : 0;
    if (_r2.i != 0) goto label16;
    return _r0.i;
    label16:;
    _r3_o = ((global::java.util.Iterator) _r1_o).next();
    _r2.i = ((global::java.util.Map_2Entry) _r3_o).hashCode();
    _r0.i = _r0.i + _r2.i;
    goto label9;
//XMLVM_END_WRAPPER[java.util.AbstractMap: int hashCode()]
}

public virtual bool isEmpty(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: boolean isEmpty()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.util.AbstractMap) _r1_o).size();
    if (_r0.i != 0) goto label8;
    _r0.i = 1;
    label7:;
    return _r0.i!=0;
    label8:;
    _r0.i = 0;
    goto label7;
//XMLVM_END_WRAPPER[java.util.AbstractMap: boolean isEmpty()]
}

public virtual global::System.Object keySet(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: java.util.Set keySet()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.AbstractMap) _r1_o)._fkeySet;
    if (_r0_o != null) goto label11;
    _r0_o = new global::java.util.AbstractMap_21();
    ((global::java.util.AbstractMap_21) _r0_o).@this((global::java.util.AbstractMap) _r1_o);
    ((global::java.util.AbstractMap) _r1_o)._fkeySet = (global::java.util.Set) _r0_o;
    label11:;
    _r0_o = ((global::java.util.AbstractMap) _r1_o)._fkeySet;
    return (global::java.util.Set) _r0_o;
//XMLVM_END_WRAPPER[java.util.AbstractMap: java.util.Set keySet()]
}

public virtual global::System.Object put(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: java.lang.Object put(java.lang.Object, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.AbstractMap: java.lang.Object put(java.lang.Object, java.lang.Object)]
}

public virtual void putAll(global::java.util.Map n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: void putAll(java.util.Map)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = ((global::java.util.Map) _r4_o).entrySet();
    _r1_o = ((global::java.util.Set) _r0_o).iterator();
    label8:;
    _r0.i = ((global::java.util.Iterator) _r1_o).hasNext() ? 1 : 0;
    if (_r0.i != 0) goto label15;
    return;
    label15:;
    _r0_o = ((global::java.util.Iterator) _r1_o).next();
    _r2_o = ((global::java.util.Map_2Entry) _r0_o).getKey();
    _r0_o = ((global::java.util.Map_2Entry) _r0_o).getValue();
    ((global::java.util.AbstractMap) _r3_o).put((global::java.lang.Object) _r2_o, (global::java.lang.Object) _r0_o);
    goto label8;
//XMLVM_END_WRAPPER[java.util.AbstractMap: void putAll(java.util.Map)]
}

public virtual global::System.Object remove(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: java.lang.Object remove(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::java.util.AbstractMap) _r2_o).entrySet();
    _r0_o = ((global::java.util.Set) _r0_o).iterator();
    if (_r3_o == null) goto label62;
    label10:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label18;
    label16:;
    _r0_o = null;
    label17:;
    return (global::java.lang.Object) _r0_o;
    label18:;
    _r2_o = ((global::java.util.Iterator) _r0_o).next();
    _r1_o = ((global::java.util.Map_2Entry) _r2_o).getKey();
    _r1.i = ((global::java.lang.Object) _r3_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label10;
    ((global::java.util.Iterator) _r0_o).remove();
    _r0_o = ((global::java.util.Map_2Entry) _r2_o).getValue();
    goto label17;
    label42:;
    _r2_o = ((global::java.util.Iterator) _r0_o).next();
    _r1_o = ((global::java.util.Map_2Entry) _r2_o).getKey();
    if (_r1_o != null) goto label62;
    ((global::java.util.Iterator) _r0_o).remove();
    _r0_o = ((global::java.util.Map_2Entry) _r2_o).getValue();
    goto label17;
    label62:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label42;
    goto label16;
//XMLVM_END_WRAPPER[java.util.AbstractMap: java.lang.Object remove(java.lang.Object)]
}

public virtual int size(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: int size()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.AbstractMap) _r1_o).entrySet();
    _r0.i = ((global::java.util.Set) _r0_o).size();
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.AbstractMap: int size()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r5_o = this;
    // Value=(this Map)
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)40)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 41))}));
    _r0.i = ((global::java.util.AbstractMap) _r5_o).isEmpty() ? 1 : 0;
    if (_r0.i == 0) goto label11;
    // Value=\173\175
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)123)), unchecked((char) unchecked((uint) 125))}));
    label10:;
    return (global::java.lang.String) _r0_o;
    label11:;
    _r1_o = new global::java.lang.StringBuilder();
    _r0.i = ((global::java.util.AbstractMap) _r5_o).size();
    _r0.i = _r0.i * 28;
    ((global::java.lang.StringBuilder) _r1_o).@this((int) _r0.i);
    _r0.i = 123;
    ((global::java.lang.StringBuilder) _r1_o).append((char) _r0.i);
    _r0_o = ((global::java.util.AbstractMap) _r5_o).entrySet();
    _r2_o = ((global::java.util.Set) _r0_o).iterator();
    label35:;
    _r0.i = ((global::java.util.Iterator) _r2_o).hasNext() ? 1 : 0;
    if (_r0.i != 0) goto label51;
    _r0.i = 125;
    ((global::java.lang.StringBuilder) _r1_o).append((char) _r0.i);
    _r0_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    goto label10;
    label51:;
    _r0_o = ((global::java.util.Iterator) _r2_o).next();
    _r3_o = ((global::java.util.Map_2Entry) _r0_o).getKey();
    if (_r3_o == _r5_o) goto label92;
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.Object) _r3_o);
    label66:;
    _r3.i = 61;
    ((global::java.lang.StringBuilder) _r1_o).append((char) _r3.i);
    _r0_o = ((global::java.util.Map_2Entry) _r0_o).getValue();
    if (_r0_o == _r5_o) goto label98;
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.Object) _r0_o);
    label80:;
    _r0.i = ((global::java.util.Iterator) _r2_o).hasNext() ? 1 : 0;
    if (_r0.i == 0) goto label35;
    // Value=, 
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r0_o);
    goto label35;
    label92:;
    // Value=(this Map)
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)40)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 41))}));
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    goto label66;
    label98:;
    // Value=(this Map)
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)40)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 41))}));
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    goto label80;
//XMLVM_END_WRAPPER[java.util.AbstractMap: java.lang.String toString()]
}

public virtual global::System.Object values(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: java.util.Collection values()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.AbstractMap) _r1_o)._fvaluesCollection;
    if (_r0_o != null) goto label11;
    _r0_o = new global::java.util.AbstractMap_22();
    ((global::java.util.AbstractMap_22) _r0_o).@this((global::java.util.AbstractMap) _r1_o);
    ((global::java.util.AbstractMap) _r1_o)._fvaluesCollection = (global::java.util.Collection) _r0_o;
    label11:;
    _r0_o = ((global::java.util.AbstractMap) _r1_o)._fvaluesCollection;
    return (global::java.util.Collection) _r0_o;
//XMLVM_END_WRAPPER[java.util.AbstractMap: java.util.Collection values()]
}

public override global::System.Object clone(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap: java.lang.Object clone()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = null;
    _r1_o = base.clone();
    ((global::java.util.AbstractMap) _r1_o)._fkeySet = (global::java.util.Set) _r0_o;
    ((global::java.util.AbstractMap) _r1_o)._fvaluesCollection = (global::java.util.Collection) _r0_o;
    return (global::java.lang.Object) _r1_o;
//XMLVM_END_WRAPPER[java.util.AbstractMap: java.lang.Object clone()]
}

//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap]
//XMLVM_END_WRAPPER[java.util.AbstractMap]

} // end of class: AbstractMap

} // end of namespace: java.util
