#include <stdio.h>
#include <string.h>

char* longestCommonPrefix(char** strs, int strsSize) {
    if (strsSize == 0) return "";

    char* pref = strs[0];
    int prefLen = strlen(pref);

    for (int i = 1; i < strsSize; i++) {
        char* s = strs[i];
        while (prefLen > strlen(s) || strncmp(pref, s, prefLen) != 0) {
            prefLen--;
            if (prefLen == 0) {
                return "";
            }
            pref[prefLen] = '\0';
        }
    }

    return pref;
}
