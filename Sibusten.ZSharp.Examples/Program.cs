// Hello World
_=Z.z.o.C.s.H.e.l.l.o.Z.s.W.o.r.l.d.Z.e.Z.z.Z.z;

// Hello World, but it goes into a register first
_=Z.z.s.a.s.H.e.l.l.o.Z.s.W.o.r.l.d.Z.e.Z.z.o.C.r.a.Z.z;

// Hello World, but it goes into a register first, which is copied to another register before printing
_=Z.z.s.a.s.H.e.l.l.o.Z.s.W.o.r.l.d.Z.e.Z.z.s.b.r.a.o.C.r.b.Z.z;

// Hello World, but it's set up in two registers and combined before printing
_=Z.z.s.a.s.H.e.l.l.o.Z.z.s.b.s.W.o.r.l.d.Z.e.Z.z.o.C.o.a.o.a.r.a.s.Z.s.Z.z.r.b.Z.z;

// Print booleans
_=Z.z.o.C.b.t.o.C.b.f.Z.z;

// Print a boolean, negate it, then print again
_=Z.z.s.a.b.t.o.C.r.a.s.a.o.n.r.a.o.C.r.a.Z.z;

// Print "A" if register 'a' is true, otherwise print "B". (It's true)
_=Z.z.s.a.b.t.i.r.a.o.C.s.A.Z.z.Z.e.o.C.s.B.Z.z.Z.Z.z;

// Print "A" if register 'a' is true, otherwise print "B". (It's false)
_=Z.z.s.a.b.f.i.r.a.o.C.s.A.Z.z.Z.e.o.C.s.B.Z.z.Z.Z.z;

// Explanation of if program
_=Z.z  // Begin program
    .s.a .b.f  // Set 'a': bool false
    .i.r.a  // If register 'a' is true
        .o.C .s.A.Z.z  // Output to console with newline: string "A"
    .Z.e  // Else
        .o.C .s.B.Z.z  // Output to console with newline: string "B"
    .Z  // End if
.Z.z;  // End program
