# Running the mono docker container to compile and run a csharp source 

`docker run --rm -v $PWD/src/:/media mono /bin/bash -c "mcs /media/helloworld.cs; mono /media/helloworld.exe floppy"`

## Break that down
* call docker, and remove the container after running
    * `docker run --rm`
* mount a shared volume so the container can access local source code:
    * `-v $PWD/src/:/media`
* the actual name of the docker image we're using
    * `mono`
* the command that compiles and runs the executable.  Note we are passing it an argument as we call it:
    * `/bin/bash -c "mcs /media/helloworld.cs; mono /media/helloworld.exe floppy"`


