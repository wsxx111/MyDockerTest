FROM microsoft/wcf

WORKDIR WcfService2

RUN powershell -NoProfile -Command \
    Import-module IISAdministration; \
    New-IISSite -Name "WcfService2"  -PhysicalPath C:\WcfService2\ -BindingInformation "*:83:"

EXPOSE 83

COPY WcfService2/ .