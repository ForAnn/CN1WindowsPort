// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public abstract class _iNavigableMap {

} // end of abstract class: _iNavigableMap

public interface NavigableMap: global::java.util.SortedMap {
 global::System.Object firstEntry();

 global::System.Object lastEntry();

 global::System.Object pollFirstEntry();

 global::System.Object pollLastEntry();

 global::System.Object ceilingEntry(global::java.lang.Object n1);

 global::System.Object ceilingKey(global::java.lang.Object n1);

 global::System.Object higherEntry(global::java.lang.Object n1);

 global::System.Object higherKey(global::java.lang.Object n1);

 global::System.Object floorEntry(global::java.lang.Object n1);

 global::System.Object floorKey(global::java.lang.Object n1);

 global::System.Object lowerEntry(global::java.lang.Object n1);

 global::System.Object lowerKey(global::java.lang.Object n1);

 global::System.Object navigableKeySet();

 global::System.Object descendingMap();

 global::System.Object descendingKeySet();

 global::System.Object subMap(global::java.lang.Object n1, bool n2, global::java.lang.Object n3, bool n4);

 global::System.Object headMap(global::java.lang.Object n1, bool n2);

 global::System.Object tailMap(global::java.lang.Object n1, bool n2);

 void clear();

 global::System.Object comparator();

 bool containsKey(global::java.lang.Object n1);

 bool containsValue(global::java.lang.Object n1);

 global::System.Object entrySet();

 bool equals(global::java.lang.Object n1);

 global::System.Object firstKey();

 global::System.Object get(global::java.lang.Object n1);

 int hashCode();

 global::System.Object headMap(global::java.lang.Object n1);

 bool isEmpty();

 global::System.Object keySet();

 global::System.Object lastKey();

 void putAll(global::java.util.Map n1);

 global::System.Object put(global::java.lang.Object n1, global::java.lang.Object n2);

 global::System.Object remove(global::java.lang.Object n1);

 int size();

 global::System.Object subMap(global::java.lang.Object n1, global::java.lang.Object n2);

 global::System.Object tailMap(global::java.lang.Object n1);

 global::System.Object values();

//XMLVM_BEGIN_WRAPPER[java.util.NavigableMap]
//XMLVM_END_WRAPPER[java.util.NavigableMap]

} // end of interface: NavigableMap

} // end of namespace: java.util
