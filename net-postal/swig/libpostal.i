 %module libpostal
 %{
 /* Includes the header in the wrapper code */
 #include "libpostal.h"
 %}
 
 /* Parse the header file to generate wrappers */
 %include "libpostal.h"