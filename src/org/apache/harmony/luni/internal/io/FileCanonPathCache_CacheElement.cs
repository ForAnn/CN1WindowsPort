// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.@internal.io {
public class FileCanonPathCache_2CacheElement: global::java.lang.Object {
public global::java.lang.String _fcanonicalPath;

public long _ftimestamp;

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache$CacheElement: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    ((global::java.lang.Object) _r2_o).@this();
    ((global::org.apache.harmony.luni.@internal.io.FileCanonPathCache_2CacheElement) _r2_o)._fcanonicalPath = (global::java.lang.String) _r3_o;
    _r0.l = global::java.lang.System.currentTimeMillis();
    ((global::org.apache.harmony.luni.@internal.io.FileCanonPathCache_2CacheElement) _r2_o)._ftimestamp = _r0.l;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache$CacheElement: void <init>(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache$CacheElement]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache$CacheElement]

} // end of class: FileCanonPathCache_2CacheElement

} // end of namespace: org.apache.harmony.luni.@internal.io
