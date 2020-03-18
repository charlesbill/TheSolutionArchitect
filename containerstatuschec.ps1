import requests


def main():
    try:
        api_url = 'http://devops-numbers-api.northeurope.azurecontainer.io:5000'
        response = requests.get(api_url + '/numbers/1')

        if response.status_code != 200:
            raise Exception('Error from WebAPI : {}'.format(response.status_code))

    except ValueError:
        raise


main()
