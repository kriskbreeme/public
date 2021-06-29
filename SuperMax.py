import requests
import json
import webbrowser
import time


response = requests.get("http://ergast.com/api/f1/current/last/drivers/max_verstappen/results.json")
#print(response.status_code)

json_data = json.loads(response.text)
verstappen_position = json_data['MRData']['RaceTable']['Races'][0]['Results'][0]['position']
verstappen_bestlap = json_data['MRData']['RaceTable']['Races'][0]['Results'][0]['FastestLap']['Time']['time']
verstappen_averagespeed = json_data['MRData']['RaceTable']['Races'][0]['Results'][0]['FastestLap']['AverageSpeed']['speed']
race_name = json_data['MRData']['RaceTable']['Races'][0]['raceName']


def play_supermax():
    time.sleep(5)
    webbrowser.open('https://youtu.be/43HCYSXZ9GI')

def win_check():
    print('\nDid Max Verstappen win the most recent F1 race? \n')
    if verstappen_position == '1':
        print(f'Max won the most recent race, which was the {race_name}!\nHis best lap time of the day was {verstappen_bestlap}\nand he carried an average speed of {verstappen_averagespeed} kph throughout the race. \n')
        print('MAX MAX MAX SUPER MAX MAX SUPER SUPER MAX MAX MAX')
        play_supermax()
    else:
        print('Get in there, Lewis')

win_check()        