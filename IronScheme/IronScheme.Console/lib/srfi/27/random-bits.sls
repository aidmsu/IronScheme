;; Copyright (c) 2009 Derick Eddington.  All rights reserved.  Licensed under an
;; MIT-style license.  My license is in the file named LICENSE from the original
;; collection this file is distributed with.  If this file is redistributed with
;; some other collection, my license must also be included.

#!r6rs
(library (srfi :27 random-bits)
  (export random-integer
          random-real
          default-random-source
          make-random-source
          random-source?
          random-source-state-ref
          random-source-state-set!
          random-source-randomize!
          random-source-pseudo-randomize!
          random-source-make-integers
          random-source-make-reals)
  
  (import (rnrs)
          (rnrs r5rs)
          (only (srfi :19 time) time-nanosecond current-time)
          (srfi :23 error tricks)
          (srfi private include)
          )
  
   (SRFI-23-error->R6RS "(library (srfi :27 random-bits))"
    (include/resolve ("srfi" "27") "random.ss"))
  )
