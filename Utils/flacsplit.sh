#!/bin/bash
FILE=`cat "$1" |grep "^FILE"`
FILE=${FILE##*FILE}
FILE=${FILE%%WAVE*}
FILE=`echo $FILE | xargs echo`
cd `dirname "$1"`
shnsplit -f "$1" -o flac -t "%n %t" "$FILE"
cuetag "$1" [0-9]*.flac 
#rm -f "$1" "$FILE"
